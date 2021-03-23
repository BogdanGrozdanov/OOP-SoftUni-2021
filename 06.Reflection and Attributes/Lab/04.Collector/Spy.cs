using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigateClass, params string[] requestFields)
        {
            Type classType = Type.GetType(investigateClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            StringBuilder stringBuilder = new StringBuilder();
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            stringBuilder.AppendLine($"Class under investigation: {investigateClass}");
            foreach (FieldInfo field in classFields.Where(f => requestFields.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string investigateClass)
        {
            Type classType = Type.GetType(investigateClass);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo field in classFields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }

            return stringBuilder.ToString().Trim();
        }

        public string RevealPrivateMethods(string investigateClass)
        {
            Type clasType = Type.GetType(investigateClass);

            MethodInfo[] classMethod = clasType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"All Private Methods of Class: {investigateClass}");
            stringBuilder.AppendLine($"Base Class: {clasType.BaseType.Name}");

            foreach (MethodInfo method in classMethod)
            {
                stringBuilder.AppendLine(method.Name);
            }
            return stringBuilder.ToString().Trim();
        }

        public string CollectGettersAndSetters(string investigateClass)
        {
            Type classType = Type.GetType(investigateClass);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (MethodInfo methods in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{methods.Name} will return {methods.ReturnType}");
            }
            foreach (MethodInfo methods in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{methods.Name} will set field of {methods.GetParameters().First().ParameterType}");
            }

            return stringBuilder.ToString().Trim();
        }

    }
}
