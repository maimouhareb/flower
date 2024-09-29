
using lab1.Models;
using Microsoft.AspNetCore.Mvc;
namespace lab1.Controllers
{
[Route("/[Controller]/[action]")]
[ApiController]


public class StudentsController:Controller
{

private readonly Datacontext _context;
//متغير برايفت يقرا من كلاس داتا كونتكس 
public StudentsController (Datacontext context){
            _context=context;



}



[HttpGet]
public ActionResult index(){
     return Json(_context.Students.ToList());

}
//هترجع كل البيانات  على شكل ليست 

public ActionResult Details(long id=0 ){
    Student s=_context.Students.Find(id);

return Json(s);





}




}



}

}
