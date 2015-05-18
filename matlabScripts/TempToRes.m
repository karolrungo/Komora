function [result] = TempToRes(temperature, coefficients)
result = polyval(coefficients,temperature);
end

