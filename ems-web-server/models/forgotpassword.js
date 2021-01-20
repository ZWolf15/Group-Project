const mongoose = require('mongoose');

// User Schema
const ForgotPasswordSchema = mongoose.Schema({
   
    email: {
      type: String
    }
    
});

module.exports = mongoose.model('Forgotpassword', ForgotPasswordSchema);


