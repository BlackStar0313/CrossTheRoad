#!/usr/bin/python
# -*- coding: utf8 -*-
#Created by zhiwei.liu

import xlrd

from xlrd import XL_CELL_NUMBER 

_excelName1 = "role"
_excelName2 = "shop"
_excelNameSuffix = ".xlsx"
_exportFileFolderCS = "../CrossRoad/Assets/Scripts/Data/"
_exportFileFolderJson = "../CrossRoad/Assets/StreamingAssets/"

_exportAllDataClass = "LocalDataCollection"

_dataExcelNum = 2 

_jsonData = []  #记录所有的数据，用给构造json用
_jsonDataType = []  #记录所有的数据，用给构造json用
_jsonDataSourceData = [] #数据表读出来的原始数据

#对应构造文本进行修改
def writeHeadCs(_writeStream, _className ):
    print("start write file ......")

    writeStr = ""
    writeStr += "using UnityEngine;\n"
    writeStr += "using System.Collections;\n"
    writeStr += "using System;\n"
    writeStr += "using System.Collections.Generic;\n\n\n"

    writeStr += "[Serializable]\n"
    writeStr += "public struct StrData{0}".format(_className)
    writeStr += " {\n"
    _writeStream.write(writeStr)
    return _writeStream
    pass

#对应构造文本进行修改
def writeTail(_writeStream):
    # _writeStream.write("\n}")
    _writeStream.close();
    # print("end write file .....")
    # print("done~~~~")
    pass


#对应构造文本进行修改
def writeToCs(_className ,_dataArray, _dataType, _rowNum , _colNum ):
    print("write data .........")
    exportFileName = "{0}Data{1}.cs".format(_exportFileFolderCS , _className)
    print("exportFileName~~~~",exportFileName )
    writeSteam = open(exportFileName , 'w')
    writeHeadCs(writeSteam,_className )

    writeStr = ""

    # 构造 列名的结构体
    colNames = _dataArray[0]
    for iCol in range(_colNum):
        # 第一行指定是int类型，用于索引
        if iCol < 1: 
            writeStr += "\tpublic int {0};".format(_dataArray[0][iCol])
        #根据第一行数据去判断类型
        elif _dataType[1][iCol] == XL_CELL_NUMBER:
            writeStr += "\tpublic int {0};".format(_dataArray[0][iCol])
        #根据第一行数据去判断类型 除python中的float类型外，其他这里全按string 处理
        else:
            writeStr += u"\tpublic string {0};".format(_dataArray[0][iCol]).encode('utf8')
        writeStr += "\n"
    pass
    writeStr += "}\n\n"
    writeStr += "[Serializable]\n"
    writeStr += "public class Data{0}".format(_className)
    writeStr += " {\n"
    writeStr += "\tpublic StrData{0}[] data;".format(_className)
    writeStr += "\n}\n\n"
    writeSteam.write(writeStr)
    writeTail(writeSteam)
    pass

def writeHeadJson(_writeStream):
    writeStr = "{"
    _writeStream.write(writeStr)
    pass

def writeTailJson(_writeStream):
    writeStr = "}"
    _writeStream.write(writeStr)
    _writeStream.close();
    pass

def writeToJson(_writeStream ,_className ,_dataArray, _dataType, _rowNum , _colNum ):
    writeStr = ""

    writeStr += "\"{0}\":".format(_className)
    writeStr += "{\"data\":["

    for iRow in range(_rowNum):
        if iRow < 1:
            continue

        writeStr += "{"
        for iCol in range(_colNum):
            if _dataType[1][iCol] == XL_CELL_NUMBER:
                writeStr += "\"{0}\":{1}".format(_dataArray[0][iCol],int(_dataArray[iRow][iCol]) )
            #根据第一行数据去判断类型 除python中的float类型外，其他这里全按string 处理
            else:
                writeStr += u"\"{0}\":\"{1}\"".format(_dataArray[0][iCol], _dataArray[iRow][iCol]).encode('utf8')

            if iCol != _colNum -1:
                writeStr += ","
        pass

        writeStr += "}"
        if iRow != _rowNum-1:
            writeStr += ","
    pass
    writeStr += "]}"


    _writeStream.write(writeStr)
    pass

def generateJson():
    print("write data to json  .........")
    exportFileName = "{0}data.json".format(_exportFileFolderJson )
    print("exportFileName~~~~",exportFileName )
    writeSteam = open(exportFileName , 'w')

    writeHeadJson(writeSteam)
    for classIdx in range(len(_jsonData)):
        writeToJson(writeSteam, _jsonDataSourceData[classIdx].name,_jsonData[classIdx] , _jsonDataType[classIdx],_jsonDataSourceData[classIdx].nrows, _jsonDataSourceData[classIdx].ncols )
        if classIdx != len(_jsonData) - 1:
            writeSteam.write(",")
    pass
    writeTailJson(writeSteam)

    pass


# 这里限定一个表只能有和表名同名的sheet才被解析
def parseExcel(_excelName):
    print("start parse excel.......")
    book = xlrd.open_workbook(_excelName + _excelNameSuffix)

    sheetNum = book.nsheets
    currentSheetIdx = 0
    for s in book.sheets():
        print("sheet ", s.name)

        if s.name != _excelName:
            continue

        dataArray = []
        dataType = []
        for row in range(s.nrows):
            values = []
            types = []
            for col in range(s.ncols):
                # print(s.cell(row,col).value)
                values.append(s.cell(row,col).value)
                types.append(s.cell(row,col).ctype)
            dataArray.append(values)
            dataType.append(types)

        _jsonData.append(dataArray)
        _jsonDataType.append(dataType)
        _jsonDataSourceData.append(s)
        writeToCs(s.name, dataArray , dataType , s.nrows , s.ncols )

        #这里只允许一个表构建一个数据
        break

    pass

# 包含所有数据的一个数据结构类
def generateLocalDataCollection():
    print("write generateLocalDataCollection  .........")
    exportFileName = "{0}.cs".format(_exportAllDataClass )
    writeSteam = open(_exportFileFolderCS + exportFileName , 'w')
    print("exportFileName~~~~",_exportFileFolderCS + exportFileName )

    writeStr = ""
    writeStr += "using UnityEngine;\n"
    writeStr += "using System.Collections;\n"
    writeStr += "using System;\n"
    writeStr += "using System.Collections.Generic;\n\n\n"

    writeStr += "[Serializable]\n"
    writeStr += "public class {0}".format(_exportAllDataClass)
    writeStr += " {\n"
    for classIdx in range(len(_jsonDataSourceData)):
       writeStr += "\tpublic Data{0} {1};\n".format(_jsonDataSourceData[classIdx].name,_jsonDataSourceData[classIdx].name)
    pass
    writeStr += "}"
    writeSteam.write(writeStr)
    writeSteam.close();
    pass

def main():
    parseExcel(_excelName1)
    parseExcel(_excelName2)
    generateJson()
    generateLocalDataCollection()
    pass

if __name__ == '__main__':
    main()
