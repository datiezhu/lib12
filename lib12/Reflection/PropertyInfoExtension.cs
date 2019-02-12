﻿using System;
using System.Linq;
using System.Reflection;

namespace lib12.Reflection
{
    /// <summary>
    /// PropertyInfoExtension
    /// </summary>
    public static class PropertyInfoExtension
    {
        /// <summary>
        /// Gets the attribute decorating given property
        /// </summary>
        /// <param name="property">The property to check</param>
        /// <returns></returns>
        public static T GetAttribute<T>(this PropertyInfo property) where T : Attribute
        {
            var attribute = property.GetCustomAttributes(typeof(T), false).SingleOrDefault();
            return (T)attribute;
        }
    }
}
