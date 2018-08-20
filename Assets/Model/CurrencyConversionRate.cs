﻿using System.Collections;
using System.Collections.Generic;

public class CurrencyConversionRate
{
    public Dictionary<string, double> Rates { get; set; }

    public double GetRate(string currencyCode)
    {
        return Rates[currencyCode];
    }

    public void ChangeRate(string currencyCode, double rate)
    {
        Rates[currencyCode] = rate;
    }

    public double GetConversionFrom(string originalCurrencyCode, string targetCurrencyCode)
    {
        double targetRate, thisRate;
        Rates.TryGetValue(targetCurrencyCode, out targetRate);
        Rates.TryGetValue(originalCurrencyCode, out thisRate);
        return targetRate / thisRate;

    }

    public CurrencyConversionRate()
    {
        Rates = new Dictionary<string, double>
        {
            { "AED", 3.673181 },
            { "AFN", 72.416074 },
            { "ALL", 109.95 },
            { "AMD", 481.746118 },
            { "ANG", 1.844888 },
            { "AOA", 259.713 },
            { "ARS", 29.200959 },
            { "AUD", 1.3693 },
            { "AWG", 1.792751 },
            { "AZN", 1.7025 },
            { "BAM", 1.706158 },
            { "BBD", 2 },
            { "BDT", 84.494386 },
            { "BGN", 1.71521 },
            { "BHD", 0.377341 },
            { "BIF", 1786 },
            { "BMD", 1 },
            { "BND", 1.510888 },
            { "BOB", 6.90935 },
            { "BRL", 3.8613 },
            { "BSD", 1 },
            { "BTC", 0.000163539509 },
            { "BTN", 68.862608 },
            { "BWP", 10.430948 },
            { "BYN", 2.043758 },
            { "BZD", 2.009903 },
            { "CAD", 1.315097 },
            { "CDF", 1616 },
            { "CHF", 0.995025 },
            { "CLF", 0.02338 },
            { "CLP", 654.2 },
            { "CNH", 6.869532 },
            { "CNY", 6.8458 },
            { "COP", 2923.178394 },
            { "CRC", 567.36259 },
            { "CUC", 1 },
            { "CUP", 25.5 },
            { "CVE", 95.4215 },
            { "CZK", 22.4713 },
            { "DJF", 178.05 },
            { "DKK", 6.5317 },
            { "DOP", 49.76 },
            { "DZD", 118.801221 },
            { "EGP", 17.841 },
            { "ERN", 14.996667 },
            { "ETB", 27.755 },
            { "EUR", 0.875545 },
            { "FJD", 2.108625 },
            { "FKP", 0.783085 },
            { "GBP", 0.783085 },
            { "GEL", 2.472742 },
            { "GGP", 0.783085 },
            { "GHS", 4.7851 },
            { "GIP", 0.783085 },
            { "GMD", 48.105 },
            { "GNF", 9100 },
            { "GTQ", 7.493084 },
            { "GYD", 208.864836 },
            { "HKD", 7.85035 },
            { "HNL", 24.039989 },
            { "HRK", 6.5094 },
            { "HTG", 66.757594 },
            { "HUF", 283.15 },
            { "IDR", 14317.144083 },
            { "ILS", 3.7157 },
            { "IMP", 0.783085 },
            { "INR", 69.094452 },
            { "IQD", 1191 },
            { "IRR", 43163.762013 },
            { "ISK", 109.000187 },
            { "JEP", 0.783085 },
            { "JMD", 134.950962 },
            { "JOD", 0.709503 },
            { "JPY", 110.875 },
            { "KES", 100.56 },
            { "KGS", 68.137481 },
            { "KHR", 4070 },
            { "KMF", 427.149956 },
            { "KPW", 900 },
            { "KRW", 1130.42 },
            { "KWD", 0.303244 },
            { "KYD", 0.833278 },
            { "KZT", 357.214019 },
            { "LAK", 8467.5 },
            { "LBP", 1523.172976 },
            { "LKR", 160.082521 },
            { "LRD", 153.000051 },
            { "LSL", 13.69 },
            { "LYD", 1.38 },
            { "MAD", 9.544102 },
            { "MDL", 16.53312 },
            { "MGA", 3296 },
            { "MKD", 53.975 },
            { "MMK", 1469.89936 },
            { "MNT", 2442.166667 },
            { "MOP", 8.084561 },
            { "MRO", 356 },
            { "MRU", 35.95 },
            { "MUR", 34.666 },
            { "MVR", 15.400001 },
            { "MWK", 727.267089 },
            { "MXN", 18.9113 },
            { "MYR", 4.084969 },
            { "MZN", 57.855413 },
            { "NAD", 13.69 },
            { "NGN", 360.5 },
            { "NIO", 31.98 },
            { "NOK", 8.361305 },
            { "NPR", 110.179703 },
            { "NZD", 1.519526 },
            { "OMR", 0.384996 },
            { "PAB", 1 },
            { "PEN", 3.2805 },
            { "PGK", 3.31 },
            { "PHP", 53.164625 },
            { "PKR", 123.95 },
            { "PLN", 3.763289 },
            { "PYG", 5746.894027 },
            { "QAR", 3.6411 },
            { "RON", 4.079804 },
            { "RSD", 103.412515 },
            { "RUB", 67.6909 },
            { "RWF", 860 },
            { "SAR", 3.75035 },
            { "SBD", 7.88911 },
            { "SCR", 13.590376 },
            { "SDG", 18.035 },
            { "SEK", 9.1231 },
            { "SGD", 1.373108 },
            { "SHP", 0.783085 },
            { "SLL", 6542.71 },
            { "SOS", 577.5 },
            { "SRD", 7.458 },
            { "SSP", 130.2634 },
            { "STD", 21050.59961 },
            { "STN", 21.3 },
            { "SVC", 8.748894 },
            { "SYP", 514.98999 },
            { "SZL", 13.69 },
            { "THB", 33.284 },
            { "TJS", 9.420854 },
            { "TMT", 3.504988 },
            { "TND", 2.764608 },
            { "TOP", 2.310538 },
            { "TRY", 6.427427 },
            { "TTD", 6.73925 },
            { "TWD", 30.746 },
            { "TZS", 2282.2 },
            { "UAH", 27.148 },
            { "UGX", 3709.631682 },
            { "USD", 1 },
            { "UYU", 30.174219 },
            { "UZS", 7807.5 },
            { "VEF", 141572.666667 },
            { "VND", 23105.287672 },
            { "VUV", 108.499605 },
            { "WST", 2.588533 },
            { "XAF", 574.319872 },
            { "XAG", 0.06530042 },
            { "XAU", 0.00082559 },
            { "XCD", 2.70255 },
            { "XDR", 0.715744 },
            { "XOF", 574.319872 },
            { "XPD", 0.00101 },
            { "XPF", 104.48031 },
            { "XPT", 0.00120811 },
            { "YER", 250.300682 },
            { "ZAR", 14.08999 },
            { "ZMW", 9.999519 },
            { "ZWL", 322.355011 }
        };
    }

    
}
