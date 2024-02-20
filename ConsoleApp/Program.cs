// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTO;

Console.WriteLine("Kodlama.io Demo\n");


//***KATEGORİ CRUD İŞLEMLERİ****
CategoryManager _categoryManager1 = new CategoryManager(new CategoryDal());

Console.WriteLine("\n***Kategori Ekleniyor***");
var resultCategory=_categoryManager1.Add(new Category { Id = 3, Name = "Grafik" });
Console.WriteLine("Durum Kodu: "+ resultCategory.statusCode +"\nSistem Mesajı: " + resultCategory.message);
CategoryList();

Console.WriteLine("\n***Kategori Güncelleniyor***");
var resultCategory1 = _categoryManager1.Update(new Category { Id = 3, Name = "Grafik (Güncellenen)" });
Console.WriteLine("Durum Kodu: " + resultCategory1.statusCode + "\nSistem Mesajı: " + resultCategory1.message);
CategoryList();

Console.WriteLine("\n***Kategori Siliniyor***");
var resultCategory2 = _categoryManager1.Delete(new Category { Id = 3, Name = "Grafik (Güncellenen)" });
Console.WriteLine("Durum Kodu: " + resultCategory2.statusCode + "\nSistem Mesajı: " + resultCategory2.message);


CategoryManager _categoryManager2 = new CategoryManager(new CategoryDal());
var resultCategori2 = _categoryManager2.GetAll();
Console.WriteLine("ID  Kategori Adı");
Console.WriteLine("----------------");
foreach (var category in resultCategori2)
{
    Console.WriteLine(category.Id + "   " + category.Name);
}
void CategoryList(){
    var resultCategori1 = _categoryManager1.GetAll();
    Console.WriteLine("ID  Kategori Adı");
    Console.WriteLine("----------------");
    foreach (var category in resultCategori1)
    {
        Console.WriteLine(category.Id + "   " + category.Name);
    }

}


//***EĞİTMEN CRUD İŞLEMLERİ****
InstructorManager _instructorManager1 = new InstructorManager(new InstructorDal());

Console.WriteLine("\n***Eğitmen Ekleniyor***");
var resultInstructor = _instructorManager1.Add(new Instructor { Id = 3, Name = "Elon", Surname="Musk",Career="Kahve dükkanı işletiyor.", ImgUrl="imaj_url_adresi_buraya" });
Console.WriteLine("Durum Kodu: " + resultInstructor.statusCode + "\nSistem Mesajı: " + resultInstructor.message);
InstructorList();

Console.WriteLine("\n***Eğitmen Güncelleniyor***");
var resultInstructor1 = _instructorManager1.Update(new Instructor { Id = 3, Name = "Elon", Surname = "Musk", Career = "Uzaya adam fırlatma uzmanı.", ImgUrl = "imaj_url_adresi_buraya" });
Console.WriteLine("Durum Kodu: " + resultInstructor1.statusCode + "\nSistem Mesajı: " + resultInstructor1.message);
InstructorList();

Console.WriteLine("\n***Eğitmen Siliniyor***");
var resultInstructor2 = _instructorManager1.Delete(new Instructor { Id = 3, Name = "Elon", Surname = "Musk", Career = "Uzaya adam fırlatma uzmanı.", ImgUrl = "imaj_url_adresi_buraya" });
Console.WriteLine("Durum Kodu: " + resultInstructor2.statusCode + "\nSistem Mesajı: " + resultInstructor2.message);
InstructorManager _instructorManager2 = new InstructorManager(new InstructorDal());
var resultInstructor3 = _instructorManager2.GetAll();
Console.WriteLine("ID  Adı        Soyad        Kariyer            ");
Console.WriteLine("---------------------------------------------------------");
foreach (var instructor in resultInstructor3)
{
    Console.WriteLine(instructor.Id + "   " + instructor.Name + "     " + instructor.Surname + "              " + instructor.Career);
}
void InstructorList()
{
    var resultInstructor1 = _instructorManager1.GetAll();
    Console.WriteLine("ID  Adı        Soyad        Kariyer            ");
    Console.WriteLine("---------------------------------------------------------");
    foreach (var instructor in resultInstructor1)
    {
        Console.WriteLine(instructor.Id + "   " + instructor.Name+"     "+ instructor.Surname+"              "+ instructor.Career);
    }

}



//*******KURS CRUD İŞLEMİ***************

CourseManager _courseManager = new CourseManager(new CourseDal());
var resultCourse= _courseManager.GetAll();
InstructorManager _instructorManager3 = new InstructorManager(new InstructorDal());
var resultInstructors = _instructorManager3.GetAll();
CategoryManager _categoryManager3 = new CategoryManager(new CategoryDal());
var resultCategories= _categoryManager3.GetAll();

var resultDTO = from course in resultCourse
                join instructor in resultInstructors
                on course.InstructorId equals instructor.Id
                join category in resultCategories
                on course.CategoryId equals category.Id
                select new CourseDetail
                {
                    InstructorName = instructor.Name,
                     InstructorSurname = instructor.Surname,
                    CategoryName = category.Name,
                    Title = course.Title,
                    Explanation = course.Explanation,
                    Fee = course.Fee,

                };

Console.WriteLine("\n***Kurslar Listeleniyor*** (Detaylı)");
Console.WriteLine("Ad Soyad        Kategori          Kurs Adı         İçerik");
Console.WriteLine("---------------------------------------------------------------");
foreach (var item in resultDTO)
{
    Console.WriteLine(item.InstructorName+" "+item.InstructorSurname + "       "+ item.CategoryName+"          "+item.Title +"        "+ item.Explanation);
}