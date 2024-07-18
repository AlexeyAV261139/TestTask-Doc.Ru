SELECT 
    brands.Name AS BrandName,
    SUM(cars.Price) AS TotalPrice
FROM 
    Cars cars
JOIN 
    Brands brands ON cars.BrandID = brands.ID
GROUP BY 
    brands.Name;
