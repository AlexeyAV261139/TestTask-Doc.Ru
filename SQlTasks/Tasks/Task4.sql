SELECT TOP 2
    countries.Name AS CountryName,
    AVG(cars.Pow) AS AveragePower
FROM 
    Cars cars
JOIN 
    Brands brands ON cars.BrandID = brands.ID
JOIN 
    Countries countries ON brands.CountryID = countries.ID
GROUP BY 
    countries.Name
ORDER BY 
    AveragePower DESC
