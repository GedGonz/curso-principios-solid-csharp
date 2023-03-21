using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
var students = studentRepository.GetAll();
exportHelper.ExportStudent(students);
Console.WriteLine("Proceso Completado");