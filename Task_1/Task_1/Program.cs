using Task_1;

Manager manager = new Manager();

Developer developer = new Developer();

manager.Salary = 10000; 
developer.Salary = 5000;
        /*Yöneticiler maaşlarının %20’sini prim olarak almalıdır. 2000 tl bonus 12000 maas
          Geliştiriciler maaşlarının %10’unu prim olarak almalıdır. 500 tl bonus 5500 maas
        */


manager.CalculateBonus();
developer.CalculateBonus();



