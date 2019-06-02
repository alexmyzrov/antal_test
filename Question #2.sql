CREATE TABLE products 
  ( 
     id   INT IDENTITY(1, 1) PRIMARY KEY, 
     NAME NVARCHAR(255) NOT NULL 
  ); 

CREATE TABLE categories 
  ( 
     id   INT IDENTITY(1, 1) PRIMARY KEY, 
     NAME NVARCHAR(255) NOT NULL 
  ); 

CREATE TABLE products_categories 
  ( 
     product_id  INT NOT NULL, 
     category_id INT NOT NULL 
  ); 

INSERT INTO products 
VALUES      ('p_ONE'), 
            ('p_TWO'), 
            ('p_THREE'), 
            ('p_FOUR') 

INSERT INTO categories 
VALUES      ('c_ONE'), 
            ('c_TWO'), 
            ('c_THREE'),
            ('c_FOUR')

INSERT INTO products_categories 
VALUES      (1, 1), 
            (1, 2), 
            (2, 2), 
            (3, 1) 

SELECT p.NAME, 
       c.NAME 
FROM   products p 
       LEFT JOIN products_categories map 
              ON p.id = map.product_id 
       LEFT JOIN categories c 
              ON map.category_id = c.id 