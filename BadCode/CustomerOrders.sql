/* Bad code */

SELECT a.id, a.name, b.date, 
c.name item_name, c.price
FROM customers a
join orders b ON a.customer_id = b.customer_id
JOIN order_items c ON b.order_id = c.order_id
WHERE a.name LIKE '%Smith%'
and b.date >= '2022-01-01'
and c.price > 100
ORDER BY b.date desc