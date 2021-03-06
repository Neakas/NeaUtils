﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeaUtils.Extensions.Datentypen
{
    public static class NummericExtensions
    {
        public static int ToInt(this int? value, int defaultIfNull = 0) => value == null
                                                                       ? defaultIfNull
                                                                       : Convert.ToInt32(value);

        public static short ToShort(this short? value, short defaultIfNull = 0) => value == null
                                                                                       ? defaultIfNull
                                                                                       : Convert.ToInt16(value);

        public static decimal ToDecimal(this decimal? value, decimal defaultIfNull = decimal.Zero) => value == null
                                                                                                          ? defaultIfNull
                                                                                                          : Convert
                                                                                                                .ToDecimal
                                                                                                                (value);

        public static bool ToBool(this bool? value, bool defaultIfNull = false) => value == null
                                                                                       ? defaultIfNull
                                                                                       : Convert.ToBoolean(value);

        public static double ToDouble(this double? value, double defaultIfNull = 0) => value == null
                                                                                       ? defaultIfNull
                                                                                       : Convert.ToDouble(value);

        public static DateTime ToDateTime(this DateTime? value, DateTime defaultIfNull = new DateTime())
            => value ?? defaultIfNull;

        public static int GetKw(this DateTime dt) => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dt, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
    }
}
