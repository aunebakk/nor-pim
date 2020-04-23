// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 4/23/2020 12:03:09 PM
// Template: sql2x.TypeScriptDurianGenerator.MethodViewIndexCode
    /// <reference path="tile.ts"/>
    // GetCartProduct Type
    type GetCartProductType = {
        FirstName: string,
        MiddleName: string,
        LastName: string,
        ClientNationalityRcd: string,
        ClientGenderRcd: string,
        ClientTitleRcd: string,
        ClientTypeRcd: string,
        ProductName: string,
        ProductStateRcd: string,
        FinancialCurrencyTypeRcd: string,
        FinancialCurrencyAgainstFinancialCurrencyTypeRcd: string,
        FinancialCurrencyTypeCode: string,
        FinancialCurrencyTypeName: string,
        Amount: string,
        CartProductStateRcd: string,
        ImageBlobFilename: string,
        DefaultUserName: string,
        DateTime: string
    };

    // declaration 
    declare var getCartProduct: GetCartProductType[]

    // class 
    class GetCartProduct extends Tile {
        constructor(
            protected imageElement: string,
            protected name: string,
            protected value: string,
            protected last24HoursCount: string,
            protected lastDateTime: string,
            protected lastUserName: string,
            protected left: number,
            protected top: number,
            protected offset: number,
            public sizeFactor: number,
            public stateMax: boolean,
            public url: string
            ) {
            super('GETCARTPRODUCT', imageElement, name, value, last24HoursCount, lastDateTime, lastUserName, left, top, offset, sizeFactor, stateMax, url);
        };

        public maxRows(): number {
            return getCartProduct.length <= 20 ? getCartProduct.length : 20;
        }

        public headerColumns(
            context: CanvasRenderingContext2D,
            left: number,
            rowPosition: number
            ) {
            context.fillText("First Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Middle Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Last Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Client Nationality", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Client Gender", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Client Title", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Client Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Product Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Product State", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Against Financial Currency Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Type Code", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Type Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Amount", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Cart Product State", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Image Blob Filename", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Default User Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Date Time", left += (100 * this.sizeFactor), rowPosition);
        }

        public columns(
            context: CanvasRenderingContext2D,
            row: number,
            left: number,
            rowPosition: number
            ) {
            context.fillText(getCartProduct[row].FirstName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].MiddleName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].LastName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ClientNationalityRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ClientGenderRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ClientTitleRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ClientTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ProductName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ProductStateRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].FinancialCurrencyTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].FinancialCurrencyAgainstFinancialCurrencyTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].FinancialCurrencyTypeCode, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].FinancialCurrencyTypeName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].Amount, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].CartProductStateRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].ImageBlobFilename, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].DefaultUserName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getCartProduct[row].DateTime, left += (100 * this.sizeFactor), rowPosition);
        }
    }
