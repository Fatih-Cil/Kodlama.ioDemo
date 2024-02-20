// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

Console.WriteLine("Kodlama.io Demo\n");

CategoryManager _categoryManager = new CategoryManager(new CategoryDal());




//TÜM KATEGORİLER LİSTELE
Console.WriteLine("Tüm Kategori Listele:");
CategoryGetAll();
Console.WriteLine("\n");

//VERİLEN ID YE GÖRE KATEGORİ GETİR
Console.WriteLine("Id'ye Göre Listele:(2)");
CategoryGetById(2);
Console.WriteLine("\n");


//YENİ KATEGORİ EKLEME
Console.WriteLine("Kategori Ekleme:");
Category category3 = new Category();
category3.Id = 3; category3.Name = "Veri Tabanı";
Category category4 = new Category();
category4.Id = 4; category4.Name = "";
CategoryAdd(category3);
CategoryGetAll();
Console.WriteLine("Kategori adı olmadan ekleme yapılmak isteniyor:");
CategoryAdd(category4); 
CategoryGetAll();
Console.WriteLine("\n");


//KATEGORİ GÜNCELLEME
Console.WriteLine("Kategori Güncelle:");
category3.Name = "Network-Güvenlik";
CategoryUpdate(category3);
CategoryGetAll();
Console.WriteLine("\n");


//KATEGORİ SİLME
Console.WriteLine("Kategori Silme:");
Category category5 = new Category();
category5.Id = 5;

//5 NOLU ID YE AİT KATEGORİ YOK. HATA MESAJI VERMESİNİ BEKLİYORUM. 
Console.WriteLine("Olmayan bir id (5):");
CategoryDelete(category5);
CategoryGetAll();
//DAHA ÖNCE OLUŞTURULAN KATEGORİ SİLİNİYOR
Console.WriteLine("\n Var olan bir id (3):");
CategoryDelete(category3);
CategoryGetAll();
Console.WriteLine("\n");







void CategoryAdd(Category category)
{
    if (_categoryManager.Add(category))
    {
Console.WriteLine("Kayıt başarılı.");
    }
    else Console.WriteLine("HATA: Kayıt yapılamadı.");



}

void CategoryDelete(Category category)
{
    if (_categoryManager.Delete(category))
    {
        Console.WriteLine("Silme işlemi başarılı");
    }
    else { Console.WriteLine("HATA:Silme işlemi yapılamadı."); }
    
}

void CategoryUpdate(Category category)
{
    if (_categoryManager.Update(category))
    {
        Console.WriteLine("Güncelleme işlemi başarılı");
    }
    else { Console.WriteLine("HATA:Güncelleme işlemi yapılamadı."); }

}

void CategoryGetById(int id)
{
    var result = _categoryManager.GetById(id);
    if (result is null) Console.WriteLine("{0} nolu id'ye ait kayıt bulunamadı",id);
    else
    {
        Console.WriteLine("Id   Category Name");
        Console.WriteLine("------------------");
        Console.WriteLine(result.Id +"  "+ result.Name);
    }
}


void CategoryGetAll()
{
    

    var result = _categoryManager.GetAll();

    if (result.Count == 0) Console.WriteLine("Hiç kategori Yok");
    else
    {
        Console.WriteLine("Id   Category Name");
        Console.WriteLine("------------------");
        foreach (var item in result) Console.WriteLine(item.Id + "  " + item.Name);

    }

}
