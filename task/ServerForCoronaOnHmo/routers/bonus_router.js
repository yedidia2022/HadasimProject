const express=require('express');
const router=express.Router();
const controlerBonus=require('../controllers/bonus')
router.get("/",controlerBonus.getBonusTress);
//router.get("/:daily",controlerBonus.getByDate);


module.exports=router;