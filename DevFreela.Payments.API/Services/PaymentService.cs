using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            //TODO IMPLEMENTAR LÓGICA DE PAGAMENTO COM GATEWAY DE PAGAMENTO
            return Task.FromResult(true);
        }
    }
}
