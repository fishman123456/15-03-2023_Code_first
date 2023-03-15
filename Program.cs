
using _15_03_2023_Code_first;
using Microsoft.EntityFrameworkCore;

using (Human_Context db = new Human_Context()) 
{
    db.Humans.Add(new Human("Олеся", "Крестикова", "женский", 36));
    db.SaveChanges();
}

//using (Human_Context db = new Human_Context())
//{
//    var data = db.Humans.ToList();

//    foreach (Human human in data)
//    {
//        Console.WriteLine(human +"\n");
//    }
//}