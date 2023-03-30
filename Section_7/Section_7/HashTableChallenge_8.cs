using System;
using System.Collections;
namespace Section_7
{
	class HashTableChallenge_8
	{
		static void main(string[] args)
		{
			Student[] students = new Student[5];
			Hashtable table = new Hashtable();

			students[0] = new Student(1, "Amir", 50);
            students[1] = new Student(2, "Saul", 60);
            students[2] = new Student(3, "Agus", 80);
            students[3] = new Student(1, "Luis", 70);
            students[4] = new Student(5, "Ere", 90);

			ValidateStudents(students, table);
        }

		static void ValidateStudents(Student[] students, Hashtable table)

        {
			foreach(Student student in students)
			{
				if (table.ContainsKey(student.Id))
				{
                    Console.WriteLine("Student with the same ID already exist");

                    
                }
				else
				{
                    table.Add(student.Id, student);
                    Console.WriteLine("Student added :)");
                }
			}
        }

	}



	class Student
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

		public Student(int id, string name, float gpa)
		{
			this.Id = id;
			this.Name = name;
			this.GPA = gpa;
		}
    }
}

