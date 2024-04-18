using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Models;

namespace UniversityEnvironment.Interfaces
{
    public interface IManualWritingToFile
    {
        string GetJson();
    }

    public interface IPersonFeatures<T> where T : User
    {
        void ShowProfile();
        void SendMessage();
    }

    public interface IStudentFeatures : IPersonFeatures<Student>
    {
        int Mark { get; set; }
        void UnsignFromCourse();
    }
    public interface ITeacherFeatures : IPersonFeatures<Teacher>
    {
        string ScienceDegree { get; set; }
    }
    public interface IObjectManager<T>
    {
        List<T> AddObject(T obj);
        List<T> RemoveObject(T obj);
    }
    public interface IIndexerGet<T>
    {
        T this[int index] { get; }
    }
    public interface IIndexerGetSet<T>
    {
        T this[int index] { get; set; }
    }
}
