using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Middleware
{
    public enum Error
    {
        NoError = 0,

        Desconocido = 666,

        /*************************************************************
          Errores sobre el inicio de sesion y conexiones al servidor
        *************************************************************/
        LoginFallido = 1001,

        /*************************************************************
            Errores sobre la consulta de infromacion
        *************************************************************/
        RegistroNoEncontrado = 2001,
    }

    //de esas cosas fumadas de c# https://www.c-sharpcorner.com/UploadFile/b942f9/how-to-add-methods-to-an-enum-in-C-Sharp/
    public static class ErrorExtensions
    {
        public static string GetMensaje(this Error error)
        {
            switch(error)
            {
                case Error.NoError: return "Sin error";
                case Error.Desconocido: return "Error Desconocido";
                case Error.RegistroNoEncontrado: return "No se pudo encontrar el registro en la base de datos";

                default: return "Error sin traducción";
            }
        }

        public static void MostrarError(this Error error)
        {
            MessageBox.Show($"Sucedió el error {(int)error}: {error.GetMensaje()} la aplicación intentará continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
