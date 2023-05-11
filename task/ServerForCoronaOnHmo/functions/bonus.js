const mongoose=require('mongoose');
const db = require('../models/index');
const vaccinationTomembers=db.vaccinationTomembers;
const members=db.members;

async function getNumMembersHevaNOtVacc(){
    let ag= [
         {
           '$lookup': {
             'from': 'vaccinationtomembers', 
             'localField': '_id', 
             'foreignField': 'memberId', 
             'as': 'result'
           }
         }, {
           '$match': {
             'vaccinationsArr.0': {
               '$exists': false
             }
           }
         }, {
           '$count': 'some heva not vacc'
         }
       ]
       return await members.aggregate(ag);
           
    }

module.exports={getNumMembersHevaNOtVacc}