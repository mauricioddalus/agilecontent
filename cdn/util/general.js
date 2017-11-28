'use strict';
const request = require('request');
const fs      = require('fs');

/**
 * Converts a remote log file into a csv pattern and save locally
 * @param   {string} tableName
 * @returns {Promise}
 */
exports.logConverter = (input, output) => {
    const d = new Date();
    const dformat = [
            d.getDate(), d.getMonth()+1, d.getFullYear()
        ].join('/') +' '+ [
            d.getHours(), d.getMinutes(), d.getSeconds()
        ].join(':');
    const header ="#Version: 1.0\n#Date: " + dformat + "\n" +
        "#Fields: provider http-method status-code uri-path time-taken response-size cache-status\n";
    return new Promise((resolve, reject) => {
        if(!input || !output) return reject('missing arguments');

        return request.get(input, (error, response, body) => {
            if (!error && response.statusCode == 200) 
                return fs.writeFile(output, header + body.replace(/\|/g, ";"), (err) => err ? reject('error while saving file') : resolve('salvo'));
            else
                return reject(`error, file not found`);
        });
    });
};
