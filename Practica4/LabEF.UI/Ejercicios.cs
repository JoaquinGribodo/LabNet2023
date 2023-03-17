using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.UI
{
    public class Ejercicios
    {
        string mensajeFinalEjercicio = "Terminó el ejercicio";
        CustomersLogic customers = new CustomersLogic();
        ProductsLogic products = new ProductsLogic();
        OrdersLogic orders = new OrdersLogic();
        CategoriesLogic categories = new CategoriesLogic();
        public void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1: Query para devolver objeto customer");

            try
            {
                var todosCustomers = customers.GetAll();
                var query1 = todosCustomers.Take(1);

                foreach (Customers customer in query1)
                {
                    Console.WriteLine($"{customer.ContactName} -- {customer.CustomerID} -- {customer.CompanyName} -- {customer.City} -- {customer.Phone}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio2() 
        {
            Console.WriteLine("\nEjercicio 2: Query para devolver todos los productos sin stock");

            try
            {
                var todosProductos = products.GetAll();
                var query2 = from product in todosProductos
                             where product.UnitsInStock == 0
                             select product;

                foreach (Products product in query2)
                {
                    Console.WriteLine($"{product.ProductName} -- {product.UnitPrice}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio3()
        {
            Console.WriteLine("\nEjercicio 3: Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");

            try
            {
                var todosProductos = products.GetAll();
                var query3 = from product in todosProductos
                             where product.UnitsInStock > 0 && product.UnitPrice > 3
                             select product;

                foreach (Products product in query3)
                {
                    Console.WriteLine($"{product.ProductName} -- {product.UnitPrice}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio4()
        {
            Console.WriteLine("\nEjercicio 4: Query para devolver todos los customers de la Región WA");

            try
            {
                var todosCustomers = customers.GetAll();
                var query4 = from customer in todosCustomers
                             where customer.Region == "WA"
                             select customer;

                foreach (Customers customer in query4)
                {
                    Console.WriteLine($"{customer.CustomerID} -- {customer.ContactName} -- {customer.CompanyName} -- {customer.City} -- {customer.Phone}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio5()
        {
            Console.WriteLine("\nEjercicio 5: Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");

            try
            {
                var todosProductos = products.GetAll();
                var query5 = todosProductos.FirstOrDefault(p => p.ProductID == 789);
                Console.WriteLine(query5);

                if (query5 == null)
                {
                    Console.WriteLine("No hay resultados disponibles.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio6()
        {
            Console.WriteLine("\nEjercicio 6: Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");

            try
            {
                var todosCustomers = customers.GetAll();
                var query6 = from customer in todosCustomers
                             select customer;

                foreach (Customers customer in query6)
                {
                    Console.WriteLine($"{customer.ContactName.ToLower()}");
                    Console.WriteLine($"{customer.ContactName.ToUpper()}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio7()
        {
            Console.WriteLine("\nEjercicio 7: Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.");

            try
            {
                var todasOrdenes = orders.GetAll();
                DateTime fecha = new DateTime(1997, 01, 01, 00, 00, 00, 000);
                var todosCustomers = customers.GetAll();
                
                var query7 = (from customer in todosCustomers
                              join order in todasOrdenes
                              on customer.CustomerID equals order.CustomerID
                              where customer.Region == "WA" && order.OrderDate >= fecha
                              select new Ejercicio7()
                              {
                                  nombre = customer.ContactName,
                                  region = customer.Region,
                                  order = (DateTime)order.OrderDate
                              }
                             ).ToList();

                foreach (Ejercicio7 ejercicio in query7)
                {
                    Console.WriteLine($"{ejercicio.nombre} -- {ejercicio.region} -- {ejercicio.order}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio8()
        {
            Console.WriteLine("\nEjercicio 8: Query para devolver los primeros 3 Customers de la Región WA");

            try
            {
                var todosCustomers = customers.GetAll();
                var query8 = todosCustomers.Where(c => c.Region == "WA");

                foreach (Customers customer in query8)
                {
                    Console.WriteLine($"{customer.ContactName} -- {customer.Region} -- {customer.City}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio9()
        {
            Console.WriteLine("\nEjercicio 9: Query para devolver lista de productos ordenados por nombre");

            try
            {
                var todosProductos = products.GetAll();
                var query9 = todosProductos.OrderBy(c => c.ProductName);

                foreach (Products product in query9)
                {
                    Console.WriteLine($"{product.ProductName}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio10()
        {
            Console.WriteLine("\nEjercicio 10: Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");

            try
            {
                var todosProductos = products.GetAll();
                var query10 = todosProductos.OrderByDescending(c => c.UnitsInStock);

                foreach (Products product in query10)
                {
                    Console.WriteLine($"{product.ProductName} -- {product.UnitsInStock}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio11()
        {
            Console.WriteLine("\nEjercicio 11: Query para devolver las distintas categorías asociadas a los productos");

            try
            {
                var todasCategories = categories.GetAll();
                var query11 = from category in todasCategories
                              select category;

                foreach (Categories category in query11)
                {
                    Console.WriteLine($"{category.CategoryID} -- {category.CategoryName}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio12()
        {
            Console.WriteLine("\nEjercicio 12: Query para devolver el primer elemento de una lista de productos.");
            
            try
            {
                var todosProductos = products.GetAll();
                var query12 = todosProductos.Take(1);

                foreach (Products product in query12)
                {
                    Console.WriteLine($"{product.ProductName}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }

        public void Ejercicio13()
        {
            Console.WriteLine("\n Ejercicio 13: Query para devolver los customer con la cantidad de ordenes asociadas.");

            try
            {
                var todosCustomers = customers.GetAll();
                var query13 = from customer in todosCustomers
                              select customer;

                foreach (Customers customer in query13)
                {
                    Console.WriteLine($"{customer.ContactName} -- {customer.Orders.Count()}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine(mensajeFinalEjercicio);
                Console.ReadKey();
            }
        }
    }
}
