using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DreamJournal.Domain.Enums
{

    public enum CountryEnum
    {
        // ISO 3166-1 Country Codes
        // --- Top 5 Priority Defaults (Value-Mapped) ---
        [Description("United States")]
        US = 0,

        [Description("United Kingdom")]
        GB = 1,

        [Description("Canada")]
        CA = 2,

        [Description("Australia")]
        AU = 3,

        [Description("Germany")]
        DE = 4,

        // --- Alphabetical ISO Alpha-2 List (Excluding top 5) ---
        [Description("Afghanistan")]
        AF,

        [Description("Albania")]
        AL,

        [Description("Algeria")]
        DZ,

        [Description("Andorra")]
        AD,

        [Description("Angola")]
        AO,

        [Description("Antigua and Barbuda")]
        AG,

        [Description("Argentina")]
        AR,

        [Description("Armenia")]
        AM,

        [Description("Austria")]
        AT,

        [Description("Azerbaijan")]
        AZ,

        [Description("Bahamas")]
        BS,

        [Description("Bahrain")]
        BH,

        [Description("Bangladesh")]
        BD,

        [Description("Barbados")]
        BB,

        [Description("Belarus")]
        BY,

        [Description("Belgium")]
        BE,

        [Description("Belize")]
        BZ,

        [Description("Benin")]
        BJ,

        [Description("Bhutan")]
        BT,

        [Description("Bolivia")]
        BO,

        [Description("Bosnia and Herzegovina")]
        BA,

        [Description("Botswana")]
        BW,

        [Description("Brazil")]
        BR,

        [Description("Brunei")]
        BN,

        [Description("Bulgaria")]
        BG,

        [Description("Burkina Faso")]
        BF,

        [Description("Burundi")]
        BI,

        [Description("Cabo Verde")]
        CV,

        [Description("Cambodia")]
        KH,

        [Description("Cameroon")]
        CM,

        [Description("Central African Republic")]
        CF,

        [Description("Chad")]
        TD,

        [Description("Chile")]
        CL,

        [Description("China")]
        CN,

        [Description("Colombia")]
        CO,

        [Description("Comoros")]
        KM,

        [Description("Congo (Brazzaville)")]
        CG,

        [Description("Congo (Kinshasa)")]
        CD,

        [Description("Costa Rica")]
        CR,

        [Description("Côte d'Ivoire")]
        CI,

        [Description("Croatia")]
        HR,

        [Description("Cuba")]
        CU,

        [Description("Cyprus")]
        CY,

        [Description("Czech Republic")]
        CZ,

        [Description("Denmark")]
        DK,

        [Description("Djibouti")]
        DJ,

        [Description("Dominica")]
        DM,

        [Description("Dominican Republic")]
        DO,

        [Description("East Timor")]
        TL,

        [Description("Ecuador")]
        EC,

        [Description("Egypt")]
        EG,

        [Description("El Salvador")]
        SV,

        [Description("Equatorial Guinea")]
        GQ,

        [Description("Eritrea")]
        ER,

        [Description("Estonia")]
        EE,

        [Description("Eswatini")]
        SZ,

        [Description("Ethiopia")]
        ET,

        [Description("Fiji")]
        FJ,

        [Description("Finland")]
        FI,

        [Description("France")]
        FR,

        [Description("Gabon")]
        GA,

        [Description("Gambia")]
        GM,

        [Description("Georgia")]
        GE,

        [Description("Ghana")]
        GH,

        [Description("Greece")]
        GR,

        [Description("Grenada")]
        GD,

        [Description("Guatemala")]
        GT,

        [Description("Guinea")]
        GN,

        [Description("Guinea-Bissau")]
        GW,

        [Description("Guyana")]
        GY,

        [Description("Haiti")]
        HT,

        [Description("Honduras")]
        HN,

        [Description("Hungary")]
        HU,

        [Description("Iceland")]
        IS,

        [Description("India")]
        IN,

        [Description("Indonesia")]
        ID,

        [Description("Iran")]
        IR,

        [Description("Iraq")]
        IQ,

        [Description("Ireland")]
        IE,

        [Description("Israel")]
        IL,

        [Description("Italy")]
        IT,

        [Description("Jamaica")]
        JM,

        [Description("Japan")]
        JP,

        [Description("Jordan")]
        JO,

        [Description("Kazakhstan")]
        KZ,

        [Description("Kenya")]
        KE,

        [Description("Kiribati")]
        KI,

        [Description("Kuwait")]
        KW,

        [Description("Kyrgyzstan")]
        KG,

        [Description("Laos")]
        LA,

        [Description("Latvia")]
        LV,

        [Description("Lebanon")]
        LB,

        [Description("Lesotho")]
        LS,

        [Description("Liberia")]
        LR,

        [Description("Libya")]
        LY,

        [Description("Liechtenstein")]
        LI,

        [Description("Lithuania")]
        LT,

        [Description("Luxembourg")]
        LU,

        [Description("Madagascar")]
        MG,

        [Description("Malawi")]
        MW,

        [Description("Malaysia")]
        MY,

        [Description("Maldives")]
        MV,

        [Description("Mali")]
        ML,

        [Description("Malta")]
        MT,

        [Description("Marshall Islands")]
        MH,

        [Description("Mauritania")]
        MR,

        [Description("Mauritius")]
        MU,

        [Description("Mexico")]
        MX,

        [Description("Micronesia")]
        FM,

        [Description("Moldova")]
        MD,

        [Description("Monaco")]
        MC,

        [Description("Mongolia")]
        MN,

        [Description("Montenegro")]
        ME,

        [Description("Morocco")]
        MA,

        [Description("Mozambique")]
        MZ,

        [Description("Myanmar")]
        MM,

        [Description("Namibia")]
        NA,

        [Description("Nauru")]
        NR,

        [Description("Nepal")]
        NP,

        [Description("Netherlands")]
        NL,

        [Description("New Zealand")]
        NZ,

        [Description("Nicaragua")]
        NI,

        [Description("Niger")]
        NE,

        [Description("Nigeria")]
        NG,

        [Description("North Korea")]
        KP,

        [Description("North Macedonia")]
        MK,

        [Description("Norway")]
        NO,

        [Description("Oman")]
        OM,

        [Description("Pakistan")]
        PK,

        [Description("Palau")]
        PW,

        [Description("Palestine")]
        PS,

        [Description("Panama")]
        PA,

        [Description("Papua New Guinea")]
        PG,

        [Description("Paraguay")]
        PY,

        [Description("Peru")]
        PE,

        [Description("Philippines")]
        PH,

        [Description("Poland")]
        PL,

        [Description("Portugal")]
        PT,

        [Description("Qatar")]
        QA,

        [Description("Romania")]
        RO,

        [Description("Russia")]
        RU,

        [Description("Rwanda")]
        RW,

        [Description("Saint Kitts and Nevis")]
        KN,

        [Description("Saint Lucia")]
        LC,

        [Description("Saint Vincent and the Grenadines")]
        VC,

        [Description("Samoa")]
        WS,

        [Description("San Marino")]
        SM,

        [Description("Sao Tome and Principe")]
        ST,

        [Description("Saudi Arabia")]
        SA,

        [Description("Senegal")]
        SN,

        [Description("Serbia")]
        RS,

        [Description("Seychelles")]
        SC,

        [Description("Sierra Leone")]
        SL,

        [Description("Singapore")]
        SG,

        [Description("Slovakia")]
        SK,

        [Description("Slovenia")]
        SI,

        [Description("Solomon Islands")]
        SB,

        [Description("Somalia")]
        SO,

        [Description("South Africa")]
        ZA,

        [Description("South Korea")]
        KR,

        [Description("South Sudan")]
        SS,

        [Description("Spain")]
        ES,

        [Description("Sri Lanka")]
        LK,

        [Description("Sudan")]
        SD,

        [Description("Suriname")]
        SR,

        [Description("Sweden")]
        SE,

        [Description("Switzerland")]
        CH,

        [Description("Syria")]
        SY,

        [Description("Taiwan")]
        TW,

        [Description("Tajikistan")]
        TJ,

        [Description("Tanzania")]
        TZ,

        [Description("Thailand")]
        TH,

        [Description("Togo")]
        TG,

        [Description("Tonga")]
        TO,

        [Description("Trinidad and Tobago")]
        TT,

        [Description("Tunisia")]
        TN,

        [Description("Turkey")]
        TR,

        [Description("Turkmenistan")]
        TM,

        [Description("Tuvalu")]
        TV,

        [Description("Uganda")]
        UG,

        [Description("Ukraine")]
        UA,

        [Description("United Arab Emirates")]
        AE,

        [Description("Uruguay")]
        UY,

        [Description("Uzbekistan")]
        UZ,

        [Description("Vanuatu")]
        VU,

        [Description("Vatican City")]
        VA,

        [Description("Venezuela")]
        VE,

        [Description("Vietnam")]
        VN,

        [Description("Yemen")]
        YE,

        [Description("Zambia")]
        ZM,

        [Description("Zimbabwe")]
        ZW
    }
}

