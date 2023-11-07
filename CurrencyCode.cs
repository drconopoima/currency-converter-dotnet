using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CurrencyConverterDotNet;

public static class CurrencyCodeExtensions
{
    public static String GetCode(this CurrencyCode code)
    {
        return Enum.GetName(typeof(CurrencyCode), (int)code);
    }
    /// <summary>
    /// CurrencyCode FromText(string text): Enum variant initializer from
    ///    input parameter 'text' case insensitive 3-letter currency code
    /// </summary>
    /// <param name="text"></param>
    /// <returns>
    /// enum CurrencyCode.'text', if 'text' is an implemented variant.
    ///    enum CurrencyCode.NONE if currency option 'text' isn't available.
    ///    Call GetOptions() to view all implemented variants.
    /// </returns>
    //                                
    public static CurrencyCode FromText(string text) {
        string[] codesArray = Enum.GetNames(typeof(CurrencyCode));
        for (int i=0; i<codesArray.Length; i++)
        {
            if ( codesArray[i] == text.ToUpper() ) 
            {
                return (CurrencyCode) i;
            }
        };
        return CurrencyCode.NONE;
    }
    /// <summary>
    /// string[] GetOptions(): Retrieve implemented enum variant names.
    /// </summary>
    /// <returns>
    /// string[] GetOptions(): Array with elements 1..N implemented variant names
    ///    sorted in alphabetical order. Element 0 is uninitialized value 'NONE'.
    /// </returns>
    public static string[] GetOptions()
    {
        
        return Enum.GetNames(typeof(CurrencyCode));
    }
}

public enum CurrencyCode {
    NONE,
    AED,
    AFN,
    ALL,
    AMD,
    ANG,
    AOA,
    ARS,
    AUD,
    AWG,
    AZN,
    BAM,
    BBD,
    BDT,
    BGN,
    BHD,
    BIF,
    BMD,
    BND,
    BOB,
    BRL,
    BSD,
    BTN,
    BWP,
    BYN,
    BZD,
    CAD,
    CDF,
    CHF,
    CLP,
    CNY,
    COP,
    CRC,
    CUC,
    CUP,
    CVE,
    CZK,
    DJF,
    DKK,
    DOP,
    DZD,
    EGP,
    ERN,
    ETB,
    EUR,
    FJD,
    FKP,
    GBP,
    GEL,
    GGP,
    GHS,
    GIP,
    GMD,
    GNF,
    GTQ,
    GYD,
    HKD,
    HNL,
    HRK,
    HTG,
    HUF,
    IDR,
    ILS,
    IMP,
    INR,
    IQD,
    IRR,
    ISK,
    JEP,
    JMD,
    JOD,
    JPY,
    KES,
    KGS,
    KHR,
    KMF,
    KPW,
    KRW,
    KWD,
    KYD,
    KZT,
    LAK,
    LBP,
    LKR,
    LRD,
    LSL,
    LYD,
    MAD,
    MDL,
    MGA,
    MKD,
    MMK,
    MNT,
    MOP,
    MRU,
    MUR,
    MVR,
    MWK,
    MXN,
    MYR,
    MZN,
    NAD,
    NGN,
    NIO,
    NOK,
    NPR,
    NZD,
    OMR,
    PAB,
    PEN,
    PGK,
    PHP,
    PKR,
    PLN,
    PYG,
    QAR,
    RON,
    RSD,
    RUB,
    RWF,
    SAR,
    SBD,
    SCR,
    SDG,
    SEK,
    SGD,
    SHP,
    SLL,
    SOS,
    SPL,
    SRD,
    STN,
    SVC,
    SYP,
    SZL,
    THB,
    TJS,
    TMT,
    TND,
    TOP,
    TRY,
    TTD,
    TVD,
    TWD,
    TZS,
    UAH,
    UGX,
    USD,
    UYU,
    UZS,
    VEF,
    VND,
    VUV,
    WST,
    XAF,
    XCD,
    XDR,
    XOF,
    XPF,
    YER,
    ZAR,
    ZMW,
    ZWD
}
