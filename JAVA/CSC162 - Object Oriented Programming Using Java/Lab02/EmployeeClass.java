//filename:EmployeeClass
//Paul Collado
//CSC-162 Lab 2 Page 357 #1

public class EmployeeClass
{
 	private String name;
 	private int idnumber;
 	private String department;
 	private String position;

 public EmployeeClass()
 {
  	name = "";
  	idnumber = 0;
  	department = "";
   	position = "";
 }

 public EmployeeClass(String n, int id, String d, String p)
 {
	 name = n;
	 idnumber = id;
	 department = d;
	 position = p;
 }
 public void setName(String n)
 {
	 name = n;
 }
 public void setIdnumber(int id)
 {
	 idnumber = id;
 }
 public void setDepartment(String d)
 {
	 department = d;
 }
 public void setPosition(String p)
 {
	 position = p;
 }
 public String getName()
 {
	 return name;
 }
 public int getIdnumber()
 {
	 return idnumber;
 }
 public String getDepartment()
 {
	 return department;
 }
 public String getPosition()
 {
	 return position;
 }
}