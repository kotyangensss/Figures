select p.Name, c.Name
from Product as p left join 
Category as c 
on p.ProductId = c.ProductId