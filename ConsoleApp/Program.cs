// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

Console.WriteLine("Kodlama.io Demo");


CategoryManager categoryManager=new CategoryManager(new CategoryDal());

var result= categoryManager.GetAll();

if (result.Count==0) Console.WriteLine("Hiç kategori Yok");
else
{
    Console.WriteLine("Id   Category Name");
    Console.WriteLine("------------------");
    foreach (var item in result) Console.WriteLine(item.Id+"  "+item.Name);

   


}

Category category1 = new Category();
category1.Id = 3; category1.Name = "Veri Tabanı";
categoryManager.Add(category1);
var result2 = categoryManager.GetAll();

if (result2.Count == 0) Console.WriteLine("Hiç kategori Yok");
else
{
    Console.WriteLine("Id   Category Name");
    Console.WriteLine("------------------");
    foreach (var item in result2) Console.WriteLine(item.Id + "  " + item.Name);




}
