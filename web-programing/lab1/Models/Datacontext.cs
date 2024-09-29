using System.Runtime.ExceptionServices;
  using Microsoft.EntityFrameworkCore;
   namespace lab1.Models
  {
  public class Datacontext : DbContext
 {
   public DbSet<proudct>? proudcts{get;set;} 


 
 public Datacontext(DbContextOptions<Datacontext>options)
 :base(options) { }
 
//انه الاتصال ب ي appsessss

 public DbSet<Rating>? Ratings{get;set;} 


 
 public DbSet<supplier>? Suppliers{get;set;} 
 public DbSet<Student>?  Students{get;set;} 
// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {//
//optionsBuilder.UseSqlServer(@"Server=DESKTOP-2263QMH\SQLEXPRESS,Database=web;Trusted _connection=True;");//
//اتصال مباشر//
 

 } 
 
 
  }
  
  