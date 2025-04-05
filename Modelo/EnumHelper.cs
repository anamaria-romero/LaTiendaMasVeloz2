using System;
using System.ComponentModel;
using System.Reflection;
using Modelo.Entities;

namespace Modelo.Helpers
{
    public static class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static RolUsuario GetRolFromDescription(string descripcion)
        {
            foreach (RolUsuario rol in Enum.GetValues(typeof(RolUsuario)))
            {
                if (GetDescription(rol) == descripcion)
                    return rol;
            }
            return RolUsuario.Empleado;
        }
    }
}
