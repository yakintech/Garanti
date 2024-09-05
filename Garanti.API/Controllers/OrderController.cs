using Garanti.API.Models;
using Garanti.Domain.Models;
using Garanti.Dto;
using Garanti.Dto.Order;
using Garanti.Infrastructure;
using Garanti.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garanti.API.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //create order endpoint
        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderRequestDto request)
        {
            //ilk islem olarak order olusturulur
            var order = new Order
            {
                CustomerId = request.CustomerId,
                OrderDate = DateTime.Now,
            };

            _unitOfWork.OrderRepository.Create(order);

            Invoice coreInvoice = new Invoice
            {
                InvoiceDate = DateTime.Now,
                Tax = 0.18m,
                Country = "USA"
            };

            //order olustuktan sonra order detail olusturulur
            foreach (var item in request.OrderItems)
            {
                var product = _unitOfWork.ProductRepository.GetById(item.ProductId);
                if (product == null)
                {
                    return BadRequest("Product not found");
                }

                var orderDetail = new OrderDetails
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = product.Price
                };

                _unitOfWork.OrderDetailRepository.Create(orderDetail);

                //urun stogu azaltma islemi

                if (product.Stock < item.Quantity)
                {
                    return BadRequest("Stock is not enough");
                }

                product.Stock -= item.Quantity;
                _unitOfWork.ProductRepository.Update(product);

                var invoice = (Invoice)coreInvoice.Clone();
                var randomNumber = new Random().Next(1, 999999);
                invoice.InvoiceNumber = "INV-" + randomNumber;
                invoice.Balance += item.Quantity * product.Price;

                _unitOfWork.InvoiceRepository.Create(invoice);



                if(request.Platform == "Web")
                {
                    var webPlatform = new WebPlatform(new CreditCardPayment());
                    webPlatform.MakePayment(item.Quantity * product.Price);
                }
                else if(request.Platform == "Mobile")
                {
                    var mobilePlatform = new MobilePlatform(new PayPalPayment());
                    mobilePlatform.MakePayment(item.Quantity * product.Price);
                }
                



            }


            _unitOfWork.Commit();

            return Ok(order.Id);
        }

    }
}


