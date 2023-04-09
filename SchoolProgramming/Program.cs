using SchoolProgramming.Business.Concrete;
using SchoolProgramming.DataAccess.Concrete;
using SchoolProgramming.Entities.Concrete;

StudentManager studentManager = new StudentManager(new InMemoryStudentDal());
TeacherManager teacherManager = new TeacherManager(new InMemoryTeacherDal());
ClassroomManager classroomManager = new ClassroomManager(new InMemoryClassroomDal());

bool isFinished = false;


while (true)
{
    if (isFinished)
    {
        break;
    }
    Console.WriteLine("Otomasyona hoşgeldiniz...");
    Console.WriteLine("Sınıf oluşturmak için s");
    Console.WriteLine("Öğrenci oluşturmak için o");
    Console.WriteLine("Öğretmen oluşturmak için og");
    Console.WriteLine("Sınıfları listelemek için ls");
    Console.WriteLine("Öğrencileri listelemek için lo");
    Console.WriteLine("Öğretmenleri listemek için log");
    Console.WriteLine("Çıkış yapmak için c");
    var firstChoose = Console.ReadLine();
    switch (firstChoose)
    {
        case "c":
            Console.WriteLine("Çıkış Yapılıyor...");
            isFinished = true;
            break;
        case "s":
            CreateClassroomScenario();
            break;
        case "o":
            CreateStudentScenario();
            break;
        case "og":
            CreateTeacherScenario();
            break;
        case "ls":
            ListClassroomScenario();
            break;
        case "lo":
            ListStudentsScenario();
            break;
        case "log":
            ListTeacherScenario();
            break;
        default:
            Console.WriteLine("Hatalı tuşlama yaptınız!");
            break;
    }
       
}

void CreateClassroomScenario()
{
    Console.WriteLine("Sınıf adını yazınız: ");
    var classroomName = Console.ReadLine();
    var classroomToAdd = new Classroom
    {
         ClassroomName = classroomName
    };

    classroomManager.Add(classroomToAdd);
}

void CreateStudentScenario()
{
    var classrooms = classroomManager.GetAll();
    if (!classrooms.Any())
    {
        Console.WriteLine("Hiç sınıf yok, önce sınıf oluşturulması gerekiyor!");
        return;
    }
    Console.WriteLine("Öğrenciyi eklemek istediğiniz sınıfın ID'sini seçiniz");
    classroomManager.WriteToConsole(classrooms);
    var classroomId = Console.ReadLine();
    var isNumeric = int.TryParse(classroomId, out int numericClassroomId);
    if (!isNumeric)
    {
        Console.WriteLine("Sadece tam sayı girin!");
        return;
    }
    Console.WriteLine("Öğrenci adını yazınız: ");
    var studentFullName = Console.ReadLine();
    studentManager.AddStudentToClassroom(numericClassroomId,new Student
    {
        FullName=studentFullName
    });

}

void CreateTeacherScenario()
{
    var classrooms = classroomManager.GetAll();
    if (!classrooms.Any())
    {
        Console.WriteLine("Hiç sınıf yok, önce sınıf oluşturulması gerekiyor!");
        return;
    }
    Console.WriteLine("Öğretmeni eklemek istediğiniz sınıfın ID'sini seçiniz");
    classroomManager.WriteToConsole(classrooms);
    var classroomId = Console.ReadLine();
    var isNumeric = int.TryParse(classroomId, out int numericClassroomId);
    if (!isNumeric)
    {
        Console.WriteLine("Sadece tam sayı girin!");
        return;
    }
    Console.WriteLine("Öğretmen adını yazınız: ");
    var teacherFullName = Console.ReadLine();
    teacherManager.AddTeacherToClassroom(numericClassroomId, new Teacher
    {
        FullName = teacherFullName
    });

}

void ListClassroomScenario()
{
    var classrooms = classroomManager.GetAll();
    if (!classrooms.Any())
    {
        Console.WriteLine("Hiç sınıf bulunamadı");
        return;
    }
    classroomManager.WriteToConsole(classrooms);
}

void ListStudentsScenario()
{
    var classrooms = classroomManager.GetAll();
    if (!classrooms.Any())
    {
        Console.WriteLine("Hiç sınıf yok, önce sınıf oluşturulması gerekiyor!");
    }
    Console.WriteLine("Öğrencileri listelemek istediğiniz sınıfın ID'sini seçiniz");
    classroomManager.WriteToConsole(classrooms);
    var classroomId = Console.ReadLine();
    var isNumeric = int.TryParse(classroomId, out int numericClassroomId);
    if (!isNumeric)
    {
        Console.WriteLine("Sadece tam sayı girin!");
        return;
    }
    var studentsToList = studentManager.GetStudentsInClassroom(numericClassroomId);
    studentManager.WriteToConsole(studentsToList);
}

void ListTeacherScenario()
{
    var classrooms = classroomManager.GetAll();
    if (!classrooms.Any())
    {
        Console.WriteLine("Hiç sınıf yok, önce sınıf oluşturulması gerekiyor!");
    }
    Console.WriteLine("Öğretmeni listelemek istediğiniz sınıfın ID'sini seçiniz");
    classroomManager.WriteToConsole(classrooms);
    var classroomId = Console.ReadLine();
    var isNumeric = int.TryParse(classroomId, out int numericClassroomId);
    if (!isNumeric)
    {
        Console.WriteLine("Sadece tam sayı girin!");
        return;
    }
    var teacherToList = teacherManager.GetTeacherInClassroom(numericClassroomId);
    teacherManager.WriteToConsole(teacherToList);
}