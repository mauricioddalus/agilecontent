'use strict';
const util = require('./util/general');

if(!process.argv[2] || !process.argv[3]) return console.log('missing arguments');

util.logConverter(process.argv[2], process.argv[3]).then(msg => console.log(msg)).catch(err => console.log(err));