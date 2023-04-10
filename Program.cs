using System;

public class LoadTxt
{
    public string Direccion {get;set;}
    public string[] AllFilesPaths {get;set;}
    public string[] TxtFilesPaths {get;set;}



    public LoadTxt(string direccion){ // metodo para cargar los txt :), constructor 
        Direccion = direccion;  //Esto almacena la direccion de la carpeta donde estan los archivos ejemplo: kayla/moogle/content
        AllFilesPaths = Directory.GetFiles(this.Direccion);
        TxtFilesPaths = new string[AllFilesPaths.Length];       
    } 

    public string[] CleanPaths(){
        for (int i = 0; i < AllFilesPaths.Length; i++)
        {
            if (this.AllFilesPaths[i].Contains(".txt"))
            {
                this.TxtFilesPaths[i]= this.AllFilesPaths[i]; 
            }
        }
        return this.TxtFilesPaths;
    }

}



class Program
{
    static void Main(){
        LoadTxt Objeto1 = new LoadTxt("/Users/mariasilvia/Documents/Moogle/MoogleTest/content");
        Objeto1.CleanPaths();
        
        
        //System.Console.WriteLine(string.Join("\n ", Objeto1.Direcciones));
    }
}