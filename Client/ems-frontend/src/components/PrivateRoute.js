import React from 'react';
import { Navigate } from 'react-router-dom';

const PrivateRoute = ({ children }) => {
  const isAuthenticated = !!localStorage.getItem('token'); // Adjust as per your auth logic
  return isAuthenticated ? children : <Navigate to="/login" replace />;
};

export default PrivateRoute;