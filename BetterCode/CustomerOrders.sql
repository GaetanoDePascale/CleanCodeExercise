/* Better Code */

SELECT c.id AS CustomerId,
        c.name AS CustomerName,
        o.date AS OrderDate,
        oi.name AS PriceName,
        oi.price AS ItemPrice
    FROM Customers AS c
        JOIN Orders AS o ON c.id = o.customer_id
        JOIN OrderItems AS oi ON o.id = oi.order_id
    WHERE c.name LIKE '%Smith%'
        AND o.date >= '2022-01-01'
        AND oi.price > 100
    ORDER BY o.date DESC;