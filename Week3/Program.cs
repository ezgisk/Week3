using Week3;

Person student = new Person();// Creating student object

student.Name = "Ezgi";
student.Surname = "Gecimli";
student.Birthday = new DateTime(1997, 4, 12);

Console.WriteLine($"Ogrencinin Adi : {student.Name} Ogrencinin Soyadi : {student.Name} Ogrencinin Dogum gunu : {student.Birthday}");

Person teacher = new Person(); // Creating teacher object
teacher.Name = "Gorkem";
teacher.Surname = "Gecimli";
teacher.Birthday = new DateTime(1998, 6, 8);

Console.WriteLine($"Ogretmenin Adi : {teacher.Name} Ogretmenin Soyadi : {teacher.Name} Ogretmenin Dogum gunu : {teacher.Birthday}");

Console.ReadKey();  