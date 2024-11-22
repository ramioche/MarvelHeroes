/**
 * Metodo para firmar la peticiona  la api. se hace desde el front ya que desde blazor no s epuede utilizar MD5. y la api requiere firmar cada peticion con mds
 * @param {any} objKeys: objeto con clave privada y clave publica para formar las peticiones
 * @returns: objeto con el timestamp, la clave privada y el hash utilizado para el request http.
 */
async function GetTs(objKeys) {
    try {
        let ts = Date.now().toString()
        let dataToEncript = ts + objKeys.privateKey + objKeys.publicKey
        let hashHex = GetMD5(dataToEncript)

        let obj = {
            Ts: ts,
            Pkey: objKeys.publicKey,
            Hash: hashHex
        }
        console.log(obj)
        return obj;
    } catch (ex) {
        console.log(ex)
    }
}

/**
 * gener un hash mds de una cadena de trxto
 * @param {any} strinBase
 * @returns
 */
function GetMD5(strinBase) {
    let hash = CryptoJS.MD5(strinBase).toString();
    return hash
}