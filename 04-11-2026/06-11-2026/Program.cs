using _06_11_2026;
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Student s = new Student("Abuzer","Kadayıf","OGR001");
s.Info();



Teacher t = new Teacher( "Ekrem","Badi","TEC001");
t.Info();
Course c = new Course("Fizik", 4, t);

Course c2 = new Course("Kimya", 2, t);
Course c3 = new Course("Biyoloji", 3, t);
Course c4 = new Course("Beden Eğitimi", 6, t);

s.CourseAdd(c);
s.CourseAdd(c2);
s.CourseAdd(c3);
s.CourseAdd(c4);
Console.WriteLine(Course.Count);

//Intern stajyer = new Intern();
//stajyer.FirstName = "Elif";
//stajyer.PersonNumber = "STJ001";
//stajyer.Info();


