CREATE TABLE orders
(
id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
prod_type VARCHAR(MAX) NULL,
prod_price FLOAT NULL,
prod_date DATE NULL,
prod_order DATE NULL


)
SELECT * FROM orders
SELECT * FROM users
SELECT * FROM customers

CREATE TABLE customers
(
id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
total_price FLOAT NULL,
date DATE NULL

)

CREATE TABLE orders 
(
id INT PRIMARY KEY IDENTITY (1,1),
customer_id VARCHAR(MAX) NULL,
prod_id VARCHAR(MAX) NULL,
prod_type VARCHAR(MAX) NULL,
prod_price FLOAT NULL,
prod_name VARCHAR(MAX) NULL,
order_date DATE NULL,
delete_order DATE NULL
)


CREATE TABLE orders (
    order_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id VARCHAR(MAX) NULL,
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    prod_type VARCHAR(MAX) NULL,
    qty VARCHAR(MAX) NULL, 
    prod_price FLOAT NULL,
    prod_order DATE NULL
);


ALTER TABLE orders
ADD order_date DATE;


DROP TABLE orders 


ALTER TABLE orders
ADD qty INT NULL