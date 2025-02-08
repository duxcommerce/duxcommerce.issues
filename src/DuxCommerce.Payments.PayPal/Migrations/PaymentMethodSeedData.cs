using System.Collections.Generic;
using DuxCommerce.StoreBuilder.Payments.DataTypes;

namespace DuxCommerce.Payments.PayPal.Migrations;

public static class PaymentMethodSeedData
{
    public static IEnumerable<PaymentMethodRow> GetMethods()
    {
        return new List<PaymentMethodRow>
        {
            new()
            {
                DisplayName = "PayPal", 
                MethodType = nameof(PayPalPaymentMethod),
                SetupController = "PayPal",
                SetupAction = "Setup"
            }
        };
    }
}