namespace StripeWebApiExample.Resources;

public record CreateCardResource(
    string Name, 
    string Number, 
    string ExpiryYear, 
    string ExpiryMonth, 
    string Cvc);