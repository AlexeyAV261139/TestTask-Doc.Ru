SELECT 
    cars_1.Name AS CarName, 
    cars_2.Name AS BaseCarName, 
    brands.Name AS BrandName
FROM 
    Cars cars_1
JOIN 
    Cars cars_2 ON cars_1.BaseID = cars_2.ID
JOIN 
    Brands brands ON cars_1.BrandID = brands.ID
WHERE 
    cars_1.BrandID = cars_2.BrandID;
