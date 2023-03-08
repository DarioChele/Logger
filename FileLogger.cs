using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public class FileLogger : ILogger{
    public string GetRutaApp()
    {
        string Ruta = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        return Ruta;
    }

    public string GetRutaCarpetaMes()
    {
        string Ruta = GetRutaApp() + "\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString("00");
        return Ruta;
    }

    public string GetRutaFileLog()
    {
        string Ruta = GetRutaCarpetaMes() + "\\" + DateTime.Today.ToString("ddMMyyyy") + " Log.log";
        return Ruta;
    }
    public string GetRutaFileIni()
    {
        string Ruta = GetRutaApp() + "\\INI.xml";
        return Ruta;
    }
    public void CreaArchivoLog()
    {
        Directory.CreateDirectory(GetRutaCarpetaMes());
        FileStream archivoLog = File.Create(GetRutaFileLog());
        archivoLog.Close();
    }//Fin CreaArchivoLog

    public void Log(string message){
        if (!File.Exists(GetRutaFileLog())){
            CreaArchivoLog();
        }

        string HoraEvento = DateTime.Now.ToString("HH:mm:ss");
        using StreamWriter streamWriter = File.AppendText(GetRutaFileLog());
        streamWriter.WriteLine(message + " " + HoraEvento);
    }
}