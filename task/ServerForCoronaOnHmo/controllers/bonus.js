const express=require('express');
const db = require('../models/index');
const bodyParser=require('body-parser');
const {getNumMembersHevaNOtVacc}=require('../functions/bonus')

async function getBonusTress(req,res){
    let data=await getNumMembersHevaNOtVacc();
    res.send(data);
          
   }

module.exports={getBonusTress}