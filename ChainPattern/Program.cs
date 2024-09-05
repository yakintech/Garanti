

using ChainPattern.Models;

List<CreditAnswerBase> creditAnswerBases = new List<CreditAnswerBase>
{
    new CreditKKBScore(),
    new CreditSponsor(),
    new CreditTCControl()
};


creditAnswerBases[0].setNextHandler(creditAnswerBases[1]);
creditAnswerBases[1].setNextHandler(creditAnswerBases[2]);


Customer customer = new Customer
{
    KKBScore = 600,
    SponsorStatus = false,
    TCNo = true
};

bool creditResult = true;

foreach (var creditAnswerBase in creditAnswerBases)
{
    creditAnswerBase.CreditRequest(customer);
    if (!creditAnswerBase.IsApproved)
    {
        creditResult = false;
        break;
    }
}

Console.WriteLine(creditResult ? "Credit approved" : "Credit not approved");