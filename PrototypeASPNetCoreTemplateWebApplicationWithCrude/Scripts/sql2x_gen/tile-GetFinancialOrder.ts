// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 4/27/2020 3:56:46 PM
// Template: sql2x.TypeScriptDurianGenerator.MethodViewIndexCode
    /// <reference path="tile.ts"/>
    // GetFinancialOrder Type
    type GetFinancialOrderType = {
        FirstName: string,
        MiddleName: string,
        LastName: string,
        ClientNationalityRcd: string,
        ClientGenderRcd: string,
        ClientTitleRcd: string,
        ClientTypeRcd: string,
        FinancialCurrencyTypeRcd: string,
        FinancialCurrencyAgainstFinancialCurrencyTypeRcd: string,
        FinancialCurrencyTypeCode: string,
        FinancialCurrencyTypeName: string,
        LocationAddressTypeRcd: string,
        AddressOne: string,
        AddressTwo: string,
        AddressThree: string,
        City: string,
        Street: string,
        State: string,
        District: string,
        Province: string,
        ZipCode: string,
        PoBox: string,
        LocationAddressComment: string,
        FinancialOrderSourceRcd: string,
        ImageBlobFilename: string,
        FinancialOrderSourceName: string,
        Comment: string,
        FinancialOrderComment: string,
        DefaultUserName: string,
        DateTime: string
    };

    // declaration 
    declare var getFinancialOrder: GetFinancialOrderType[]

    // class 
    class GetFinancialOrder extends Tile {
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
            super('GETFINANCIALORDER', imageElement, name, value, last24HoursCount, lastDateTime, lastUserName, left, top, offset, sizeFactor, stateMax, url);
        };

        public maxRows(): number {
            return getFinancialOrder.length <= 20 ? getFinancialOrder.length : 20;
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
            context.fillText("Financial Currency Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Against Financial Currency Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Type Code", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Currency Type Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Location Address Type", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Address One", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Address Two", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Address Three", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("City", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Street", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("State", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("District", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Province", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Zip Code", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Po Box", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Location Address Comment", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Order Source", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Image Blob Filename", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Order Source Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Comment", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Financial Order Comment", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Default User Name", left += (100 * this.sizeFactor), rowPosition);
            context.fillText("Date Time", left += (100 * this.sizeFactor), rowPosition);
        }

        public columns(
            context: CanvasRenderingContext2D,
            row: number,
            left: number,
            rowPosition: number
            ) {
            context.fillText(getFinancialOrder[row].FirstName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].MiddleName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].LastName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ClientNationalityRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ClientGenderRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ClientTitleRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ClientTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialCurrencyTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialCurrencyAgainstFinancialCurrencyTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialCurrencyTypeCode, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialCurrencyTypeName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].LocationAddressTypeRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].AddressOne, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].AddressTwo, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].AddressThree, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].City, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].Street, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].State, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].District, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].Province, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ZipCode, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].PoBox, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].LocationAddressComment, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialOrderSourceRcd, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].ImageBlobFilename, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialOrderSourceName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].Comment, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].FinancialOrderComment, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].DefaultUserName, left += (100 * this.sizeFactor), rowPosition);
            context.fillText(getFinancialOrder[row].DateTime, left += (100 * this.sizeFactor), rowPosition);
        }
    }
