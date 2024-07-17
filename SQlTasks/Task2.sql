SELECT 
    brands.Name AS BrandName
FROM 
    Cars cars
JOIN 
    Brands brands ON cars.BrandID = brands.ID
GROUP BY 
    brands.Name
HAVING 
    COUNT(cars.ID) > 3;
