from flask import Flask, jsonify
from flask_cors import CORS

import TotalGunler
import DevamsizlikVerileri
import TahminKayitlari

Api = Flask(__name__)
CORS(Api)


@Api.route('/', methods=['GET'])
def get_employees():
    try:
        DevamsizlikVerileri.devamsizlik()
        TahminKayitlari.tahmin()
        TotalGunler.totalkayitlar()
        return jsonify({'status': 'success'})  # Geçerli bir yanıt döndürülüyor
    except Exception as e:
        print("Beklenmeyen bir hata oluştu:", str(e))
        return jsonify({'status': 'error', 'message': str(e)})  # Hata mesajını içeren geçerli bir yanıt döndürülüyor


if __name__ == '__main__':
    Api.run()