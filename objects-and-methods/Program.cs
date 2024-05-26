using objects_and_methods;

Student student1 = new Student("Sarah", "Psychology", 4.0, 110);
Student student2 = new Student("Andrey", "Math", 2.5, 20);

Console.WriteLine(student1.HasHonors()); 
Console.WriteLine(student2.HasHonors()); 

Console.WriteLine(student1.GradeLevel());
Console.WriteLine(student2.GradeLevel());

