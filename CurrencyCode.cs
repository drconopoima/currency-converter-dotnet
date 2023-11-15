using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CurrencyConverterDotNet;

public static class CurrencyCodeExtensions
{
    public static string[] Names = {
        "Unrecognized/Uninitialized Currency",
        "United Arab Emirates dirham",
        "Afghan afghani",
        "Albanian lek",
        "Armenian dram",
        "Netherlands Antillean guilder",
        "Angolan kwanza",
        "Argentine peso",
        "Australian dollar",
        "Aruban florin",
        "Azerbaijani manat",
        "Bosnia and Herzegovina convertible mark",
        "Barbados dollar",
        "Bangladeshi taka",
        "Bulgarian lev",
        "Bahraini dinar",
        "Burundian franc",
        "Bermudian dollar",
        "Brunei dollar",
        "Boliviano",
        "Brazilian real",
        "Bahamian dollar",
        "Bhutanese ngultrum",
        "Botswana pula",
        "New Belarusian ruble",
        "Belarusian ruble",
        "Belize dollar",
        "Canadian dollar",
        "Congolese franc",
        "Swiss franc",
        "Unidad de Fomento",
        "Chilean peso",
        "Renminbi|Chinese yuan",
        "Colombian peso",
        "Costa Rican colon",
        "Cuban convertible peso",
        "Cuban peso",
        "Cape Verde escudo",
        "Czech koruna",
        "Djiboutian franc",
        "Danish krone",
        "Dominican peso",
        "Algerian dinar",
        "Egyptian pound",
        "Eritrean nakfa",
        "Ethiopian birr",
        "Euro",
        "Fiji dollar",
        "Falkland Islands pound",
        "Pound sterling",
        "Georgian lari",
        "Ghanaian cedi",
        "Gibraltar pound",
        "Gambian dalasi",
        "Guinean franc",
        "Guatemalan quetzal",
        "Guernsey Pound",
        "Guyanese dollar",
        "Hong Kong dollar",
        "Honduran lempira",
        "Croatian kuna",
        "Haitian gourde",
        "Hungarian forint",
        "Indonesian rupiah",
        "Israeli new shekel",
        "Isle of Man Pound",
        "Indian rupee",
        "Iraqi dinar",
        "Iranian rial",
        "Icelandic króna",
        "Jersey Pound",
        "Jamaican dollar",
        "Jordanian dinar",
        "Japanese yen",
        "Kenyan shilling",
        "Kyrgyzstani som",
        "Cambodian riel",
        "Comoro franc",
        "North Korean won",
        "South Korean won",
        "Kuwaiti dinar",
        "Cayman Islands dollar",
        "Kazakhstani tenge",
        "Lao kip",
        "Lebanese pound",
        "Sri Lankan rupee",
        "Liberian dollar",
        "Lesotho loti",
        "Libyan dinar",
        "Moroccan dirham",
        "Moldovan leu",
        "Malagasy ariary",
        "Macedonian denar",
        "Myanmar kyat",
        "Mongolian tögrög",
        "Macanese pataca",
        "Mauritanian ouguiya",
        "Mauritian rupee",
        "Maldivian rufiyaa",
        "Malawian kwacha",
        "Mexican peso",
        "Mexican Unidad de Inversion",
        "Malaysian ringgit",
        "Mozambican metical",
        "Namibian dollar",
        "Nigerian naira",
        "Nicaraguan córdoba",
        "Norwegian krone",
        "Nepalese rupee",
        "New Zealand dollar",
        "Omani rial",
        "Panamanian balboa",
        "Peruvian Sol",
        "Papua New Guinean kina",
        "Philippine peso",
        "Pakistani rupee",
        "Polish złoty",
        "Paraguayan guaraní",
        "Qatari riyal",
        "Romanian leu",
        "Serbian dinar",
        "Russian ruble",
        "Rwandan franc",
        "Saudi riyal",
        "Solomon Islands dollar",
        "Seychelles rupee",
        "Sudanese pound",
        "Swedish krona",
        "Singapore dollar",
        "Saint Helena pound",
        "Sierra Leonean leone",
        "Somali shilling",
        "Surinamese dollar",
        "South Sudanese pound",
        "São Tomé and Príncipe dobra",
        "Salvadoran colón",
        "Syrian pound",
        "Swazi lilangeni",
        "Thai baht",
        "Tajikistani somoni",
        "Turkmenistani manat",
        "Tunisian dinar",
        "Tongan paʻanga",
        "Turkish lira",
        "Trinidad and Tobago dollar",
        "Tuvalu Dollar",
        "New Taiwan dollar",
        "Tanzanian shilling",
        "Ukrainian hryvnia",
        "Ugandan shilling",
        "United States dollar",
        "Uruguay Peso en Unidades Indexadas",
        "Uruguayan peso",
        "Uzbekistan som",
        "Venezuelan bolívar",
        "Vietnamese đồng",
        "Vanuatu vatu",
        "Samoan tala",
        "Central African CFA franc",
        "East Caribbean dollar",
        "West African CFA franc",
        "CFP franc",
        "Yemeni rial",
        "South African rand",
        "Zambian kwacha",
        "Zimbabwean dollar"
    };
    public static string[] CountryCurrencyDesc = {
        "Afghanistan-Afghani",
        "Albania-Lek",
        "Algeria-Dinar",
        "Angola-Kwanza",
        "Antigua & Barbuda-E. Caribbean Dollar",
        "Argentina-Peso",
        "Armenia-Dram",
        "Australia-Dollar",
        "Azerbaijan-Manat",
        "Bahamas-Dollar",
        "Bahrain-Dinar",
        "Bangladesh-Taka",
        "Barbados-Dollar",
        "Belarus-New Ruble",
        "Belize-Dollar",
        "Benin-CFA Franc",
        "Bermuda-Dollar",
        "Bolivia-Boliviano",
        "Bosnia-Marka",
        "Botswana-Pula",
        "Brazil-Real",
        "Brunei-Dollar",
        "Bulgaria-Lev New",
        "Burkina Faso-CFA Franc",
        "Burundi-Franc",
        "Cambodia-Riel",
        "Cameroon-CFA Franc",
        "Canada-Dollar",
        "Cape Verde-Escudo",
        "Cayman Islands-Dollar",
        "Central African Rep.-CFA Franc",
        "Chad-CFA Franc",
        "Chile-Peso",
        "China-Renminbi",
        "Colombia-Peso",
        "Comoros-Franc",
        "Congo-CFA Franc",
        "Costa Rica-Colon",
        "Cote D'ivoire-CFA Franc",
        "Cuba-Chavito",
        "Cuba-Peso",
        "Czech Republic-Koruna",
        "Dem. Rep. of Congo-Congolese Franc",
        "Denmark-Krone",
        "Djibouti-Franc",
        "Dominican Republic-Peso",
        "Ecuador-Dolares",
        "Egypt-Pound",
        "El Salvador-Dollar",
        "Equatorial Guinea-CFA Franc",
        "Eritrea-Nakfa",
        "Eswatini-Lilangeni",
        "Ethiopia-Birr",
        "Euro Zone-Euro",
        "Fiji-Dollar",
        "Gabon-CFA Franc",
        "Gambia-Dalasi",
        "Georgia-Lari",
        "Ghana-Cedi",
        "Grenada-E.Caribbean Dollar",
        "Guatemala-Quentzal",
        "Guinea Bissau-CFA Franc",
        "Guinea-Franc",
        "Guyana-Dollar",
        "Haiti-Gourde",
        "Honduras-Lempira",
        "Hong Kong-Dollar",
        "Hungary-Forint",
        "Iceland-Krona",
        "India-Rupee",
        "Indonesia-Rupiah",
        "Iran-Rial",
        "Iraq-Dinar",
        "Israel-Shekel",
        "Jamaica-Dollar",
        "Japan-Yen",
        "Jordan-Dinar",
        "Kazakhstan-Tenge",
        "Kenya-Shilling",
        "Korea-Won",
        "Kuwait-Dinar",
        "Kyrgyzstan-Som",
        "Laos-Kip",
        "Lebanon-Pound",
        "Lesotho-Maloti",
        "Liberia-Dollar",
        "Libya-Dinar",
        "Madagascar-Ariary",
        "Malawi-Kwacha",
        "Malaysia-Ringgit",
        "Maldives-Rufiyaa",
        "Mali-CFA Franc",
        "Marshall Islands-U.S. Dollar",
        "Mauritania-Ouguiya",
        "Mauritius-Rupee",
        "Mexico-Peso",
        "Micronesia-U.S. Dollar",
        "Moldova-LEU",
        "Mongolia-Tugrik",
        "Morocco-Dirham".
        "Mozambique-Metical",
        "Myanmar-Kyat",
        "Nambia-Dollar",
        "Nepal-Rupee",
        "Netherlands Antilles-Guilder",
        "New Zealand-Dollar",
        "Nicaragua-Cordoba",
        "Niger-CFA Franc",
        "Nigeria-Naira",
        "Norway-Krone",
        "Oman-Rial",
        "Pakistan-Rupee",
        "Palau-Dollar",
        "Panama-Dolares",
        "Papua New Guinea-Kina",
        "Paraguay-Guarani",
        "Peru-Sol",
        "Philippines-Peso",
        "Poland-Zloty",
        "Qatar-Riyal",
        "Rep. of N. Macedonia-Denar",
        "Romania-New Leu",
        "Russia-Ruble",
        "Rwanda-Franc",
        "Sao Tome & Principe-New Dobras",
        "Saudi Arabia-Riyal",
        "Senegal-CFA Franc",
        "Serbia-Dinar",
        "Seychelles-Rupee",
        "Sierra Leone-Leone",
        "Sierra Leone-Old Leone",
        "Singapore-Dollar",
        "Solomon Islands-Dollar",
        "Somali-Shilling",
        "South Africa-Rand",
        "South Sudan-Sudanese Pound",
        "Sri Lanka-Rupee",
        "St. Lucia-E. Caribbean Dollar",
        "Sudan-Pound",
        "Suriname-Dollar",
        "Sweden-Krona",
        "Switzerland-Franc",
        "Syria-Pound",
        "Taiwan-Dollar",
        "Tajikistan-Somoni",
        "Tanzania-Shilling",
        "Thailand-Baht",
        "Timor-Leste-Dili",
        "Togo-CFA Franc",
        "Tonga-Pa'anga",
        "Trinidad & Tobago-Dollar",
        "Tunisia-Dinar",
        "Turkey-New Lira",
        "Turkmenistan-New Manat",
        "Uganda-Shilling",
        "Ukraine-Hryvnia",
        "United Arab Emirates-Dirham",
        "United Kingdom-Pound",
        "Uruguay-Peso",
        "Uzbekistan-Som",
        "Vanuatu-Vatu",
        "Venezuela-Bolivar Soberano",
        "Venezuela-Fuerte (OLD)",
        "Vietnam-Dong",
        "Western Samoa-Tala",
        "Yemen-Rial",
        "Zambia-New Kwacha",
        "Zimbabwe-RTGS"
    };
    /// <summary>
    /// string GetCode(CurrencyCode code): Retrieve 3-letter currency code
    ///    abbreviation of the enum variant CurrencyCode in argument
    /// </summary>
    /// <param name="code"></param>
    /// <returns>
    /// string 'abbr', abbreviated code of the currently initialized
    ///    variant of CurrencyCode enum
    /// </returns>
    public static String GetCode(CurrencyCode code)
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
    /// <summary>
    /// string GetName(CurrencyCode code): Retrieve legible currency name from
    ///    enum variant CurrencyCode in argument
    /// </summary>
    /// <param name="code"></param>
    /// <returns>
    /// string 'name', legible currency name (and issuing entity if applicable)
    ///    for initialized variant of CurrencyCode enum
    /// </returns>
    public static String GetName(CurrencyCode code)
    {
        return Names[(int) code];
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
    BYR,
    BZD,
    CAD,
    CDF,
    CHF,
    CLF,
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
    MRO,
    MUR,
    MVR,
    MWK,
    MXN,
    MXV,
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
    SRD,
    SSP,
    STD,
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
    UYI,
    UYU,
    UZS,
    VEF,
    VND,
    VUV,
    WST,
    XAF,
    XCD,
    XOF,
    XPF,
    YER,
    ZAR,
    ZMW,
    ZWD
}
