"use strict";(self.webpackChunk=self.webpackChunk||[]).push([[143],{758:()=>{},170:(e,t,n)=>{function r(e){return Array.isArray(e)||ArrayBuffer.isView(e)}function o(e){(function(e){return null!=e&&"function"==typeof e.Dispose})(e)&&e.Dispose()}function i(e,t){var n,r;return(null===(n=Object.getPrototypeOf(e))||void 0===n?void 0:n.constructor)===(null===(r=Object.getPrototypeOf(t))||void 0===r?void 0:r.constructor)}class s{constructor(e){this.iter=e}"System.Collections.Generic.IEnumerator`1.get_Current"(){return this.current}"System.Collections.IEnumerator.get_Current"(){return this.current}"System.Collections.IEnumerator.MoveNext"(){const e=this.iter.next();return this.current=e.value,!e.done}"System.Collections.IEnumerator.Reset"(){throw new Error("JS iterators cannot be reset")}Dispose(){}}function u(e){return"function"==typeof e.GetEnumerator?e.GetEnumerator():new s(e[Symbol.iterator]())}function l(e){return{[Symbol.iterator](){return this},next(){const t=e["System.Collections.IEnumerator.MoveNext"]();return{done:!t,value:t?e["System.Collections.IEnumerator.get_Current"]():void 0}}}}function c(e,t){let n=e.toString(10);for(;n.length<t;)n="0"+n;return n}function a(e){const t=e;return"number"==typeof t.offset?t.offset:1===e.kind?0:-6e4*e.getTimezoneOffset()}function f(e,t){return(e=e<0&&null!=t&&10!==t?4294967295+e+1:e).toString(t)}class d{static id(e){return d.idMap.has(e)||d.idMap.set(e,++d.count),d.idMap.get(e)}}function h(e){return 2654435761*e|0}function m(e){return 0===e.length?0:e.reduce(((e,t)=>(e<<5)+e^t))}function g(e){var t;if(null==e)return 0;switch(typeof e){case"boolean":return e?1:0;case"number":return h(e);case"string":return function(e){let t=0,n=5381;const r=e.length;for(;t<r;)n=33*n^e.charCodeAt(t++);return n}(e);default:return function(e){return"function"==typeof e.GetHashCode}(e)?e.GetHashCode():r(e)?function(e){const t=e.length,n=new Array(t);for(let r=0;r<t;r++)n[r]=g(e[r]);return m(n)}(e):e instanceof Date?function(e){return e.getTime()}(e):(null===(t=Object.getPrototypeOf(e))||void 0===t?void 0:t.constructor)===Object?m(Object.values(e).map((e=>g(e)))):h(d.id(e))}}function y(e,t){return function(e,t,n){if(null==e)return null==t;if(null==t)return!1;if(e.length!==t.length)return!1;for(let r=0;r<e.length;r++)if(!n(e[r],t[r]))return!1;return!0}(e,t,p)}function p(e,t){var n;return e===t||(null==e?null==t:null!=t&&"object"==typeof e&&(function(e){return"function"==typeof e.Equals}(e)?e.Equals(t):r(e)?r(t)&&y(e,t):e instanceof Date?t instanceof Date&&0===v(e,t):(null===(n=Object.getPrototypeOf(e))||void 0===n?void 0:n.constructor)===Object&&function(e,t){const n=Object.keys(e),r=Object.keys(t);if(n.length!==r.length)return!1;n.sort(),r.sort();for(let o=0;o<n.length;o++)if(n[o]!==r[o]||!p(e[n[o]],t[r[o]]))return!1;return!0}(e,t)))}function v(e,t){let n,r;return"offset"in e&&"offset"in t?(n=e.getTime(),r=t.getTime()):(n=e.getTime()+a(e),r=t.getTime()+a(t)),n===r?0:n<r?-1:1}function E(e,t){return e===t?0:e<t?-1:1}function w(e,t){return function(e,t,n){if(null==e)return null==t?0:1;if(null==t)return-1;if(e.length!==t.length)return e.length<t.length?-1:1;for(let r=0,o=0;r<e.length;r++)if(o=n(e[r],t[r]),0!==o)return o;return 0}(e,t,C)}function C(e,t){var n;return e===t?0:null==e?null==t?0:-1:null==t?1:"object"!=typeof e?e<t?-1:1:function(e){return"function"==typeof e.CompareTo}(e)?e.CompareTo(t):r(e)?r(t)?w(e,t):-1:e instanceof Date?t instanceof Date?v(e,t):-1:(null===(n=Object.getPrototypeOf(e))||void 0===n?void 0:n.constructor)===Object?function(e,t){const n=Object.keys(e),r=Object.keys(t);if(n.length!==r.length)return n.length<r.length?-1:1;n.sort(),r.sort();for(let o=0,i=0;o<n.length;o++){const s=n[o];if(s!==r[o])return s<r[o]?-1:1;if(i=C(e[s],t[s]),0!==i)return i}return 0}(e,t):-1}function b(e,t,n){return e(t,n)>0?t:n}function S(e){const t={};for(const n of e)t[n[0]]=n[1];return t}d.idMap=new WeakMap,d.count=0;const x=Symbol("curried");function A(e,t){if(null==t||t.length>1)return t;const n=(...n)=>{let r=t;for(let t=0;t<e;t++)r=r(n[t]);return r};return n[x]=t,n}function N(e,t,n){return r=>1===t?n(...e.concat([r])):N(e.concat([r]),t-1,n)}function I(e,t){return null==t||1===t.length?t:x in t?t[x]:N([],e,t)}function O(e,t,n){if(null!=t){if(x in t){t=t[x];for(let e=0;e<n.length;e++)t=t(n[e]);return t}return N(n,e,t)}}function k(e,t=0){var n,r;if(null!=e&&"object"==typeof e){if("function"==typeof e.toString)return e.toString();if(Symbol.iterator in e)return function(e){let t=0,n="[";for(const r of e){if(0===t)n+=k(r);else{if(100===t){n+="; ...";break}n+="; "+k(r)}t++}return n+"]"}(e);{const o=null===(n=Object.getPrototypeOf(e))||void 0===n?void 0:n.constructor;return o===Object&&t<10?"{ "+Object.entries(e).map((([e,n])=>e+" = "+k(n,t+1))).join("\n  ")+" }":null!==(r=null==o?void 0:o.name)&&void 0!==r?r:""}}return String(e)}class T{get name(){return this.cases()[this.tag]}toJSON(){return 0===this.fields.length?this.name:[this.name].concat(this.fields)}toString(){return function(e,t){if(0===t.length)return e;{let n="",r=!0;return 1===t.length?(n=k(t[0]),r=n.indexOf(" ")>=0):n=t.map((e=>k(e))).join(", "),e+(r?" (":" ")+n+(r?")":"")}}(this.name,this.fields)}GetHashCode(){const e=this.fields.map((e=>g(e)));return e.splice(0,0,h(this.tag)),m(e)}Equals(e){return this===e||!!i(this,e)&&this.tag===e.tag&&y(this.fields,e.fields)}CompareTo(e){return this===e?0:i(this,e)?this.tag===e.tag?w(this.fields,e.fields):this.tag<e.tag?-1:1:-1}}class M{toJSON(){return function(e){const t={},n=Object.keys(e);for(let r=0;r<n.length;r++)t[n[r]]=e[n[r]];return t}(this)}toString(){return function(e){return"{ "+Object.entries(e).map((([e,t])=>e+" = "+k(t))).join("\n  ")+" }"}(this)}GetHashCode(){return function(e){return m(Object.values(e).map((e=>g(e))))}(this)}Equals(e){return function(e,t){if(e===t)return!0;if(i(e,t)){const n=Object.keys(e);for(let r=0;r<n.length;r++)if(!p(e[n[r]],t[n[r]]))return!1;return!0}return!1}(this,e)}CompareTo(e){return function(e,t){if(e===t)return 0;if(i(e,t)){const n=Object.keys(e);for(let r=0;r<n.length;r++){const o=C(e[n[r]],t[n[r]]);if(0!==o)return o}return 0}return-1}(this,e)}}function j(e){const t=e<0,n=(e=Math.abs(e))%36e5/6e4;return(t?"-":"+")+c(~~(e/36e5),2)+":"+c(n,2)}function G(e,t){const n=e.toISOString();return"first"===t?n.substring(0,n.indexOf("T")):n.substring(n.indexOf("T")+1,n.length-1)}function D(e,t,n){return t.replace(/(\w)\1*/g,(t=>{let r=Number.NaN;switch(t.substring(0,1)){case"y":const o=n?e.getUTCFullYear():e.getFullYear();r=t.length<4?o%100:o;break;case"M":r=(n?e.getUTCMonth():e.getMonth())+1;break;case"d":r=n?e.getUTCDate():e.getDate();break;case"H":r=n?e.getUTCHours():e.getHours();break;case"h":const i=n?e.getUTCHours():e.getHours();r=i>12?i%12:i;break;case"m":r=n?e.getUTCMinutes():e.getMinutes();break;case"s":r=n?e.getUTCSeconds():e.getSeconds();break;case"f":r=n?e.getUTCMilliseconds():e.getMilliseconds()}return Number.isNaN(r)?t:r<10&&t.length>1?"0"+r:""+r}))}const U=Symbol("numeric");function P(e,t){return"number"==typeof e?e.toPrecision(t):e[U]().toPrecision(t)}function _(e,t){return"number"==typeof e?e.toExponential(t):e[U]().toExponential(t)}function L(e){return"number"==typeof e?(Number(e)>>>0).toString(16):e[U]().toHex()}function F(e){return e.replace(/[\-\[\]\/\{\}\(\)\*\+\?\.\\\^\$\|]/g,"\\$&")}const R=/(^|[^%])%([0+\- ]*)(\*|\d+)?(?:\.(\d+))?(\w)/g;function H(e){return{input:e,cont:(t=e,e=>{R.lastIndex=0;const n=[],r=[];let o=0,i=R.exec(t);for(;i;){const e=i.index+(i[1]||"").length;n.push(t.substring(o,e).replace(/%%/g,"%")),r.push(i),o=R.lastIndex,R.lastIndex-=1,i=R.exec(t)}return 0===n.length?e(t.replace(/%%/g,"%")):(n.push(t.substring(o).replace(/%%/g,"%")),J(e,n,r))})};var t}function q(e){return function(e,t){return"string"==typeof t?e(t):t.cont(e)}((e=>e),e)}function z(e,t,n,r,o){let i="";if(t=t||"",o=o||"","number"==typeof(s=e)||(null==s?void 0:s[U]))switch("x"!==o.toLowerCase()&&(function(e,t){return function(e,t){return"number"==typeof e?e<t?-1:e>t?1:0:e.CompareTo(t)}(e,t)<0}(e,0)?(e=function(e,t){return"number"==typeof e?-1*e:e[U]().multiply(-1)}(e),i="-"):t.indexOf(" ")>=0?i=" ":t.indexOf("+")>=0&&(i="+")),r=null==r?null:parseInt(r,10),o){case"f":case"F":e=function(e,t){return"number"==typeof e?e.toFixed(t):e[U]().toFixed(t)}(e,r=null!=r?r:6);break;case"g":case"G":e=null!=r?P(e,r):P(e);break;case"e":case"E":e=null!=r?_(e,r):_(e);break;case"x":e=L(e);break;case"X":e=L(e).toUpperCase();break;default:e=String(e)}else e=e instanceof Date?function(e,t,n){return null!=e.offset?function(e,t){var n,r,o;const i=new Date(e.getTime()+(null!==(n=e.offset)&&void 0!==n?n:0));if("string"!=typeof t)return i.toISOString().replace(/\.\d+/,"").replace(/[A-Z]|\.\d+/g," ")+j(null!==(r=e.offset)&&void 0!==r?r:0);if(1!==t.length)return D(i,t,!0);switch(t){case"D":case"d":return G(i,"first");case"T":case"t":return G(i,"second");case"O":case"o":return function(e,t){const n=e.toISOString();return n.substring(0,n.length-1)+j(t)}(i,null!==(o=e.offset)&&void 0!==o?o:0);default:throw new Error("Unrecognized Date print format")}}(e,t):function(e,t){const n=1===e.kind;if("string"!=typeof t)return n?e.toUTCString():e.toLocaleString();if(1!==t.length)return D(e,t,n);switch(t){case"D":case"d":return n?G(e,"first"):e.toLocaleDateString();case"T":case"t":return n?G(e,"second"):e.toLocaleTimeString();case"O":case"o":return function(e,t){if(t)return e.toISOString();{const t=null==e.kind||2===e.kind;return c(e.getFullYear(),4)+"-"+c(e.getMonth()+1,2)+"-"+c(e.getDate(),2)+"T"+c(e.getHours(),2)+":"+c(e.getMinutes(),2)+":"+c(e.getSeconds(),2)+"."+c(e.getMilliseconds(),3)+(t?j(-6e4*e.getTimezoneOffset()):"")}}(e,n);default:throw new Error("Unrecognized Date print format")}}(e,t)}(e):k(e);var s;if(n="number"==typeof n?n:parseInt(n,10),isNaN(n))e=i+e;else{const r=t.indexOf("0")>=0,o=t.indexOf("-")>=0,s=o||!r?" ":"0";e="0"===s?i+(e=V(e,n-i.length,s,o)):V(i+e,n,s,o)}return e}function J(e,t,n,r="",o=-1){return(...i)=>{let s=r;const u=t.slice(),l=n.slice();for(const e of i){const[,,t,n,r,i]=l[0];let c=n;if(o>=0)c=o,o=-1;else if("*"===c){if(e<0)throw new Error("Non-negative number required");o=e;continue}s+=u[0],s+=z(e,t,c,r,i),u.splice(0,1),l.splice(0,1)}return 0===l.length?(s+=u[0],e(s)):J(e,u,l,s,o)}}function $(e,t){return Array.isArray(t)?t.join(e):Array.from(t).join(e)}function V(e,t,n,r){n=n||" ",t-=e.length;for(let o=0;o<t;o++)e=r?e+n:n+e;return e}function B(e,t,n,r){if(r="number"==typeof r?r:0,(n="number"==typeof n?n:void 0)&&n<0)throw new Error("Count cannot be less than zero");if(0===n)return[];const o=1==(1&r),i=2==(2&r);t=(t=(t=t||[]).filter((e=>e)).map(F)).length>0?t:["\\s"];const s=[],u=new RegExp(t.join("|"),"g");let l=!0,c=0;do{const t=u.exec(e);if(null===t){const t=i?e.substring(c).trim():e.substring(c);(!o||t.length>0)&&s.push(t),l=!1}else{const r=i?e.substring(c,t.index).trim():e.substring(c,t.index);(!o||r.length>0)&&(null!=n&&s.length+1===n?(s.push(i?e.substring(c).trim():e.substring(c)),l=!1):s.push(r)),c=u.lastIndex}}while(l);return s}function W(e,t,n){if(t+(n||0)>e.length)throw new Error("Invalid startIndex and/or length");return null!=n?e.substr(t,n):e.substr(t)}class Y{constructor(e){this.value=e}toJSON(){return this.value}toString(){return String(this.value)}GetHashCode(){return g(this.value)}Equals(e){return null!=e&&p(this.value,e instanceof Y?e.value:e)}CompareTo(e){return null==e?1:C(this.value,e instanceof Y?e.value:e)}}function X(e){return null==e||e instanceof Y?new Y(e):e}function Z(e){if(null==e)throw new Error("Option has no value");return e instanceof Y?e.value:e}function K(e,t){return null!=e?Z(e):t}function Q(e,t){return null!=e?Z(e):t()}function ee(e,t){return null!=t?X(e(Z(t))):void 0}class te extends M{constructor(e,t){super(),this.head=e,this.tail=t}toString(){return"["+$("; ",this)+"]"}Equals(e){return this===e||((e,t)=>{e:for(;;){const n=e,r=t,o=[n.tail,r.tail];if(null!=o[0]){if(null!=o[1]){const i=o[0],s=o[1];if(p(n.head,r.head)){e=i,t=s;continue e}return!1}return!1}return null==o[1]}})(this,e)}GetHashCode(){return 0|((e,t,n)=>{for(;;){const r=e,o=t,i=n,s=i.tail;if(null==s)return 0|o;{const u=s;if(r>18)return 0|o;e=r+1,t=(o<<1)+g(i.head)+631*r,n=u}}})(0,0,this)}toJSON(e){return Array.from(this)}CompareTo(e){return 0|((e,t)=>{e:for(;;){const n=e,r=t,o=[n.tail,r.tail];if(null!=o[0]){if(null!=o[1]){const i=o[0],s=o[1],u=0|C(n.head,r.head);if(0===u){e=i,t=s;continue e}return 0|u}return 1}return null!=o[1]?-1:0}})(this,e)}GetEnumerator(){return new ne(this)}[Symbol.iterator](){return l(this.GetEnumerator())}"System.Collections.IEnumerable.GetEnumerator"(){return u(this)}}class ne{constructor(e){this.xs=e,this.it=this.xs,this.current=null}"System.Collections.Generic.IEnumerator`1.get_Current"(){return this.current}"System.Collections.IEnumerator.get_Current"(){return this.current}"System.Collections.IEnumerator.MoveNext"(){const e=this,t=e.it.tail;if(null!=t){const n=t;return e.current=e.it.head,e.it=n,!0}return!1}"System.Collections.IEnumerator.Reset"(){const e=this;e.it=e.xs,e.current=null}Dispose(){}}function re(){return new te(null,void 0)}function oe(e,t){return new te(e,t)}function ie(e){return null==e.tail}function se(e){if(null!=e.tail)return e.head;throw new Error("Collection was empty.\\nParameter name: list")}function ue(e){const t=e.tail;if(null!=t)return t;throw new Error("Collection was empty.\\nParameter name: list")}function le(){return re()}function ce(e,t){return oe(e,t)}function ae(e){return oe(e,re())}function fe(e){return ie(e)}function de(e){return se(e)}function he(e){return ue(e)}function me(e,t,n){let r=t,o=n;for(;!ie(o);)r=e(r,se(o)),o=ue(o);return r}function ge(e){return me(((e,t)=>oe(t,e)),re(),e)}function ye(e,t){me(((t,n)=>{e(n)}),void 0,t)}function pe(e){return function(e,t){let n=t;for(let t=e.length-1;t>=0;t--)n=oe(e[t],n);return n}(e,re())}function ve(e,t){return me(((e,t)=>oe(t,e)),t,ge(e))}function Ee(e,t){const n=re(),r=me(((t,n)=>{const r=new te(e(n),void 0);return t.tail=r,r}),n,t),o=re();return r.tail=o,ue(n)}function we(e,t){const n=re(),r=me(((t,n)=>{const r=e(n);if(null==r)return t;{const e=new te(Z(r),void 0);return t.tail=e,e}}),n,t),o=re();return r.tail=o,ue(n)}function Ce(e,t,n){ye((n=>{try{n(t)}catch(t){e(t)}}),n)}function be(){return le()}function Se(e,t,n){if(null==t)return null==n;if(null==n)return!1;{let r=0,o=!0;const i=0|t.length,s=0|n.length;if(i>s)return!1;if(i<s)return!1;for(;r<i&&o;)o=e(t[r],n[r]),r=r+1|0;return o}}const xe="The input sequence has an insufficient number of elements.";function Ae(){throw new Error("Enumeration has not started. Call MoveNext.")}function Ne(){throw new Error("Enumeration already finished.")}class Ie{constructor(e){this.f=e}toString(){let e=0,t="seq [";const n=u(this);try{for(;e<4&&n["System.Collections.IEnumerator.MoveNext"]();)e>0&&(t+="; "),t+=k(n["System.Collections.Generic.IEnumerator`1.get_Current"]()),e=e+1|0;return 4===e&&(t+="; ..."),t+"]"}finally{o(n)}}GetEnumerator(){return this.f()}[Symbol.iterator](){return l(this.GetEnumerator())}"System.Collections.IEnumerable.GetEnumerator"(){return this.f()}}class Oe{constructor(e,t,n){this.current=e,this.next=t,this.dispose=n}"System.Collections.Generic.IEnumerator`1.get_Current"(){return this.current()}"System.Collections.IEnumerator.get_Current"(){return this.current()}"System.Collections.IEnumerator.MoveNext"(){return this.next()}"System.Collections.IEnumerator.Reset"(){!function(){throw new Error("Reset is not supported on this enumerator.")}()}Dispose(){this.dispose()}}function ke(e,t,n){return new Oe(e,t,n)}function Te(e,t,n){let r,o=!1,i=X(e());const s=()=>{if(null!=i){const e=Z(i);try{n(e)}finally{i=void 0}}},u=()=>{try{s()}finally{r=void 0}};return ke((()=>(o||Ae(),null!=r?Z(r):Ne())),(()=>{if(o||(o=!0),null!=i){const e=Z(i);let n;try{n=t(e)}catch(e){throw u(),e}return null!=n?(r=n,!0):(u(),!1)}return!1}),s)}function Me(e){return function(e){return new Ie(e)}(e)}function je(e){return t="source",null==e&&function(e){throw new Error(e)}(t),u(e);var t}function Ge(e){return Me((()=>u(e())))}function De(e){return Me((()=>function(e){let t,n,r,i=!1,s=!1;const l=()=>{if(s=!0,null!=n){const e=n;try{o(e)}finally{n=void 0}}if(null!=t){const e=t;try{o(e)}finally{t=void 0}}};return ke((()=>(i?s&&Ne():Ae(),null!=r?Z(r):Ne())),(()=>{let c;if(i||(i=!0),s)return!1;{let i;for(;null==i;){const s=[t,n];if(null!=s[0])if(null!=s[1]){const e=s[1];if(e["System.Collections.IEnumerator.MoveNext"]())r=X(e["System.Collections.Generic.IEnumerator`1.get_Current"]()),i=!0;else try{o(e)}finally{n=void 0}}else{const e=s[0];e["System.Collections.IEnumerator.MoveNext"]()?(c=e["System.Collections.Generic.IEnumerator`1.get_Current"](),n=u(c)):(l(),i=!1)}else t=u(e)}return Z(i)}}),(()=>{s||l()}))}(e)))}function Ue(){return Ge((()=>new Array(0)))}function Pe(e){return Ge((()=>function(e,t){const n=function(e,t){return"function"==typeof e?new e(t):new Array(t)}(void 0,1);return n[0]=e,n}(e)))}function _e(e){return r(e)?pe(e):e instanceof te?e:function(e){let t,n;if(r(e))return pe(e);if(e instanceof te)return e;{const r=re();let i=r;const s=u(e);try{for(;s["System.Collections.IEnumerator.MoveNext"]();){const e=s["System.Collections.Generic.IEnumerator`1.get_Current"]();t=i,n=new te(e,void 0),t.tail=n,i=n}}finally{o(s)}const l=i,c=re();return l.tail=c,ue(r)}}(e)}function Le(e,t,n){return Me((()=>{let r=-1;return Te(e,(e=>(r=r+1|0,t(r,e))),n)}))}function Fe(e,t){return De([e,t])}function Re(e,t){return n=()=>je(t),r=t=>t["System.Collections.IEnumerator.MoveNext"]()?X(e(t["System.Collections.Generic.IEnumerator`1.get_Current"]())):void 0,i=e=>{o(e)},Me((()=>Te(n,r,i)));var n,r,i}function He(e,t){return Me((()=>{const n=je(t);try{for(let t=1;t<=e;t++)if(!n["System.Collections.IEnumerator.MoveNext"]())throw new Error(xe+"\\nParameter name: source");return function(e,t){return ke((()=>t["System.Collections.Generic.IEnumerator`1.get_Current"]()),(()=>t["System.Collections.IEnumerator.MoveNext"]()),(()=>{try{o(t)}finally{e()}}))}((()=>{}),n)}catch(e){throw o(n),e}}))}function qe(e,t,n,r,o){const i=function(e,t,n,r){const o=0|C(e,n);if(0===o)throw new Error("The step of a range cannot be zero");const i=o>0;return n=>{const o=0|C(n,t);return i&&o<=0||!i&&o>=0?[n,r(n,e)]:void 0}}(t,n,r,o);return Ge((()=>{return t=i,n=e,Me((()=>function(e,t){let n,r=t;return ke((()=>{if(null!=n){const e=n[0];return n[1],e}return Ae()}),(()=>{if(n=e(r),null!=n){n[0];const e=n[1];return r=e,!0}return!1}),(()=>{}))}(t,n)));var t,n}))}Symbol.iterator;class ze extends T{constructor(e,...t){super(),this.tag=0|e,this.fields=t}cases(){return["Writable","ReadWritable"]}}class Je{constructor(e){var t,n;this.state=new ze(0,(t=new Array(b(E,e,10)),n=b(E,e,10),t.fill(null,0,0+n)),0)}}function $e(e){const t=e.state;if(1===t.tag){const n=0|t.fields[1],r=0|t.fields[2],o=t.fields[0],i=(r+1)%o.length|0;return e.state=i===n?new ze(0,o,n):new ze(1,o,n,i),X(o[r])}}class Ve extends M{constructor(e,t,n,r,o,i,s){super(),this.init=e,this.update=t,this.subscribe=n,this.view=r,this.setState=o,this.onError=i,this.syncDispatch=s}}function Be(e,t){const n=t.init(e),i=n[0],s=new Je(10);let l=!1,c=i;const a=O(1,t.syncDispatch,[e=>{if(l)!function(e,t){const n=e.state;if(1===n.tag){const s=0|n.fields[1],u=0|n.fields[2],l=n.fields[0];l[s]=t;const c=(s+1)%l.length|0;e.state=c===u?new ze(1,(r=u,i=l,Array.from(Ge((()=>Fe(He(r,i),Ge((()=>{return Fe((e=r,t=i,Le((()=>je(t)),((t,n)=>{if(t<e){if(n["System.Collections.IEnumerator.MoveNext"]())return X(n["System.Collections.Generic.IEnumerator`1.get_Current"]());throw new Error(xe+"\\nParameter name: source")}}),(e=>{o(e)}))),Ge((()=>{return e=e=>Pe(null),n=i.length,t=qe(0,1,n,0,((e,t)=>e+t)),Ge((()=>De(Re(e,t))));var e,t,n})));var e,t}))))))),l.length,0):new ze(1,l,c,u)}else{const r=0|n.fields[1],o=n.fields[0];o[r]=t;const i=(r+1)%o.length|0;e.state=new ze(1,o,i,r)}var r,i}(s,e);else{l=!0;let n=X(e);for(;null!=n;){const e=Z(n);try{const n=t.update(e,c),r=n[0];t.setState(r,a),Ce((n=>{t.onError([q(H("Error in command while handling: %A"))(e),n])}),a,n[1]),c=r}catch(n){t.onError([q(H("Unable to process the message: %A"))(e),n])}n=$e(s)}l=!1}}]);t.setState(i,a),Ce((e=>{t.onError(["Error intitializing:",e])}),a,function(e){const t=re();let n=t;const i=e=>{n=me(((e,t)=>{const n=new te(t,void 0);return e.tail=n,n}),n,e)};if(r(e))e.forEach(i);else if(e instanceof te)ye(i,e);else{const t=u(e);try{for(;t["System.Collections.IEnumerator.MoveNext"]();)i(t["System.Collections.Generic.IEnumerator`1.get_Current"]())}finally{o(t)}}const s=n,l=re();return s.tail=l,ue(t)}(pe([(()=>{try{return t.subscribe(i)}catch(e){return t.onError(["Unable to subscribe:",e]),be()}})(),n[1]])))}var We=n(961),Ye=n(526);class Xe extends M{constructor(e,t,n){super(),this.model=e,this.render=t,this.equal=n}}class Ze extends Ye.Component{constructor(e){super(e)}shouldComponentUpdate(e,t){return!this.props.equal(this.props.model,e.model)}render(){return this.props.render()}}const Ke=Ye;function Qe(e){return{Dispose(){e()}}}function et(e){var t;t=e,(0,Ye.useEffect)((()=>{const e=t();return()=>{e.Dispose()}}))}function tt(e,t){const n=K(t,[]);return Ke.useMemo(e,n)}function nt(e){const t=(r=e,Ke.useRef(r)),n=function(e,n){const r=K([],[]);return Ke.useCallback((e=>t.current(e)),r)}();var r,o,i;return o=()=>{t.current=e},i=e=>(o(),Qe((()=>{}))),(0,Ye.useLayoutEffect)((()=>{const e=i();return()=>{e.Dispose()}})),n}const rt=(()=>{try{if("undefined"!=typeof window&&"function"==typeof window.addEventListener){const e={passive:!0};window.addEventListener("testPassiveEventSupport",(e=>{}),e),window.removeEventListener("testPassiveEventSupport",(e=>{}))}}catch(e){}return!1})();function ot(e){return ee((e=>e.passive&&!rt?{capture:e.capture,once:e.once,passive:!1}:e),e)}function it(e){return null!=(t=e)?(e=>e.capture?{capture:!0}:void 0)(Z(t)):void 0;var t}function st(e,t){return 0===t.indexOf(e)?t:void 0}function ut(e,t){return function(e,t){const n=e.lastIndexOf(t);return n>=0&&n===e.length-t.length}(t,e)?t:void 0}function lt(e){const t=$("&",Ee((e=>$("=",[encodeURIComponent(e[0]),encodeURIComponent(e[1])])),e));return""===t?"":"?"+t}function ct(e,t){return function(e){return 1===e?e=>{let t,n,r,o,i,s;return t=st("/",e),null!=t?(n=t,"#"+n):(r=st("#/",e),null!=r?(o=r,o):(i=st("#",e),null!=i?(s=i,"#/"+W(s,1,s.length-1)):"#/"+e))}:e=>{let t,n;return t=st("/",e),null!=t?(n=t,n):"/"+e}}(t)($("/",Ee((e=>e.indexOf("?")>=0||0===e.indexOf("#")||0===e.indexOf("/")?e:encodeURIComponent(e)),e)))}function at(e){const t=ge(e);return fe(t)?void 0:fe(he(t))?[le(),de(t)]:[ge(he(t)),de(t)]}function ft(e,t,n){1===t?history.pushState(void 0,"",ct(e,n)):history.replaceState(void 0,"",ct(e,n));const r=document.createEvent("CustomEvent");r.initEvent("CUSTOM_NAVIGATION_EVENT",!0,!0),window.dispatchEvent(r)}function dt(e,t){return function(e,t){let n,r;const o=re();let i=o,s=t;for(;!ie(s);){let t=e(se(s));for(;!ie(t);)n=i,r=new te(se(t),void 0),n.tail=r,i=r,t=ue(t);s=ue(s)}const u=i,l=re();return u.tail=l,ue(o)}((e=>{if("string"!=typeof(t=e)||/^\s*$/.test(t))return le();{const t=function(e,...t){return 0===t.length?e.trimEnd():e.replace(new RegExp("["+F(t.join(""))+"]+$"),"")}(e,"#");if("?"===t)return le();if(null!=st("?",t))return ae(t);{const e=t.split("?");if(Se(((e,t)=>e===t),e,null)||1!==e.length){if(Se(((e,t)=>e===t),e,null)||2!==e.length)return le();if(""===e[1]){const t=e[0];return ae(decodeURIComponent(t))}{const t=e[0],n=e[1];return pe([decodeURIComponent(t),"?"+n])}}{const t=e[0];return ae(decodeURIComponent(t))}}}var t}),pe(B(null!=st("#",e)?W(e,1,e.length-1):1!==t||null==ut("#",e)&&null==ut("#/",e)?e:"",["/"],null,0)))}const ht=function(e,t,n,r){const i=Ke.memo(e,A(2,K(I(2,n),null)));var s,u;return s=t=>{e.displayName=t},function(e,t,n){const r=je(n);try{let n=t;for(;r["System.Collections.IEnumerator.MoveNext"]();)n=e(n,r["System.Collections.Generic.IEnumerator`1.get_Current"]())}finally{o(r)}}(((e,t)=>{s(t)}),void 0,null==(u=t)?[]:[Z(u)]),e=>{const t=function(e,t){if(null==e)return t;{const n=e;return t.key=n(t),t}}(r,e);return Ke.createElement(i,t)}}((e=>{const t=nt((t=>{const n=K(e.onUrlChanged,(e=>{}));!function(e,t,n){t(dt(2===e?window.location.pathname+window.location.search:window.location.hash,e))}(K(e.hashMode,1),n)}));if(window.navigator.userAgent.indexOf("Trident")>=0||window.navigator.userAgent.indexOf("MSIE")>=0){const e="hashchange",n=e=>{t(e)},r=void 0,o=tt((()=>ot(r)),[r]),i=tt((()=>it(r)),[r]),s=tt((()=>e=>{n(e)}),[n]);et(nt((()=>{if(null==o)window.addEventListener(e,s);else{const t=o;window.addEventListener(e,s,t)}return Qe((()=>{if(null==i)window.removeEventListener(e,s);else{const t=i;window.removeEventListener(e,s,t)}}))})))}else{const e="popstate",n=t,r=void 0,o=tt((()=>ot(r)),[r]),i=tt((()=>it(r)),[r]),s=tt((()=>e=>{n(e)}),[n]);et(nt((()=>{if(null==o)window.addEventListener(e,s);else{const t=o;window.addEventListener(e,s,t)}return Qe((()=>{if(null==i)window.removeEventListener(e,s);else{const t=i;window.removeEventListener(e,s,t)}}))})))}const n="CUSTOM_NAVIGATION_EVENT",r=t,o=void 0,i=tt((()=>ot(o)),[o]),s=tt((()=>it(o)),[o]),u=tt((()=>e=>{r(e)}),[r]);et(nt((()=>{if(null==i)window.addEventListener(n,u);else{const e=i;window.addEventListener(n,u,e)}return Qe((()=>{if(null==s)window.removeEventListener(n,u);else{const e=s;window.removeEventListener(n,u,e)}}))})));const l=e.application;return null==l?null:l}),void 0,undefined,undefined);class mt extends T{constructor(e,...t){super(),this.tag=0|e,this.fields=t}cases(){return["Install","Use","BorderRadius"]}}const gt=new mt(0);function yt(e){let t;switch(t=fe(e)?2:"use"===de(e)?fe(he(e))?0:3:"borderradius"===de(e)&&fe(he(e))?1:3,t){case 0:return new mt(1);case 1:return new mt(2);case 2:return new mt(0);case 3:return gt}}function pt(e){return[e,le()]}function vt(e){switch(e.tag){case 1:return pt(ae("use"));case 2:return pt(ae("borderradius"));default:return pt(le())}}function Et(e){const t=vt(e);return n=e=>{const n=t[1];Q(ee((e=>{ft(ve(e[0],ae(e[1]+lt(n))),1,1)}),at(t[0])),(()=>{ft(ae(lt(n)),1,1)}))},ae(n);var n}function wt(e,t){const n=function(e){return me(A(2,(e=>{const t=e[0],n=e[1];return e=>{const r=e;return"className"===r[0]?[ce(k(r[1]),t),n]:[t,ce(e,n)]}})),[le(),le()],ge(e))}(t);return ce(["className",$(" ",ce(e,n[0]))],n[1])}function Ct(){let e,t,n,r,o,i;const s=[(0,Ye.createElement)("div",{className:"description",children:Ke.Children.toArray(["Using NuGet package command"])}),(e=ae((t=ae((0,Ye.createElement)("pre",S(pe([["data-prefix","$"],(n=[(0,Ye.createElement)("code",{children:["Install-Package Feliz.ChartJS"]})],["children",Ke.Children.toArray(Array.from(n))])])))),(0,Ye.createElement)("div",{className:"mockup-code",children:Ke.Children.toArray(Array.from(t))}))),(0,Ye.createElement)("div",{className:"max-w-xl",children:Ke.Children.toArray(Array.from(e))})),(0,Ye.createElement)("div",{className:"description",children:Ke.Children.toArray(["or Paket"])}),(r=ae((o=ae((0,Ye.createElement)("pre",S(pe([["data-prefix","$"],(i=[(0,Ye.createElement)("code",{children:["paket add Feliz.ChartJS"]})],["children",Ke.Children.toArray(Array.from(i))])])))),(0,Ye.createElement)("div",{className:"mockup-code",children:Ke.Children.toArray(Array.from(o))}))),(0,Ye.createElement)("div",{className:"max-w-xl",children:Ke.Children.toArray(Array.from(r))}))];return Ye.createElement(Ye.Fragment,{},...s)}function bt(e){const t=(n=(e,t)=>(0,Ye.createElement)("pre",S(_e(Ge((()=>Fe(Pe(["data-prefix",f(e+1)]),Ge((()=>Fe(t.indexOf("// ")>=0?Pe(["className","text-warning"]):Ue(),Ge((()=>{let e;return Pe((e=[(0,Ye.createElement)("code",{children:[t]})],["children",Ke.Children.toArray(Array.from(e))]))}))))))))))),r=B(e,["\n"],null,0),Le((()=>je(r)),((e,t)=>t["System.Collections.IEnumerator.MoveNext"]()?X(n(e,t["System.Collections.Generic.IEnumerator`1.get_Current"]())):void 0),(e=>{o(e)})));var n,r;return(0,Ye.createElement)("div",{className:"mockup-code",children:Ke.Children.toArray(Array.from(t))})}function St(){let e,t;const n=[(0,Ye.createElement)("div",{className:"description",children:Ke.Children.toArray(["After installation just open proper namespace:"])}),(e=ae(bt("open Feliz.ChartJS")),(0,Ye.createElement)("div",{className:"max-w-xl",children:Ke.Children.toArray(Array.from(e))})),(t=pe(["Now you can start using library. Everything important starts with ",(0,Ye.createElement)("code",{className:"code",children:"ChartJS.*"})," module."]),(0,Ye.createElement)("div",{className:"description",children:Ke.Children.toArray(Array.from(t))}))];return Ye.createElement(Ye.Fragment,{},...n)}class xt extends T{constructor(e,...t){super(),this.tag=0|e,this.fields=t}cases(){return["UrlChanged","SetTheme"]}}class At extends M{constructor(e,t){super(),this.Page=e,this.Theme=t}}function Nt(e,t,n,r,o){let i,s,u,l,c,a;const f=pe([(i=ae((s=ae((u=ae((0,Ye.createElement)("label",S(wt("btn",pe([["className","btn-square"],["className","btn-ghost"],["htmlFor","main-menu"],(l=[(0,Ye.createElement)("svg",S(pe([["viewBox","0 0 24 24"],["className","inline-block w-6 h-6 stroke-current"],(c=ae((0,Ye.createElement)("path",{d:"M4 6h16M4 12h16M4 18h16",strokeWidth:2})),["children",Ke.Children.toArray(Array.from(c))])])))],["children",Ke.Children.toArray(Array.from(l))])]))))),(0,Ye.createElement)("div",{className:"lg:hidden",children:Ke.Children.toArray(Array.from(u))}))),(0,Ye.createElement)("div",{className:"navbar-start",children:Ke.Children.toArray(Array.from(s))}))),(0,Ye.createElement)("div",{className:"navbar",children:Ke.Children.toArray(Array.from(i))})),(a=pe([(0,Ye.createElement)("h2",S(pe([(d=["className","text-primary"],h=["className","my-6 text-5xl font-bold"],["className",$(" ",we((e=>{const t=e;return"className"===t[0]?k(t[1]):void 0}),pe([d,h])))]),["children",n]]))),o]),(0,Ye.createElement)("div",{className:"px-5 py-5",children:Ke.Children.toArray(Array.from(a))}))]);var d,h;return(0,Ye.createElement)("div",{className:"drawer-content",children:Ke.Children.toArray(Array.from(f))})}function It(e){let t,n,r,o,i;const s=(t,n)=>{const r=ae((0,Ye.createElement)("a",S(_e(Ge((()=>Fe(p(e,n)?Pe(["className","active"]):Ue(),Ge((()=>Fe(Pe(["children",t]),Ge((()=>{let e,t;return Fe(Pe(["href",(e=vt(n),t=e[1],Q(ee((e=>ct(ve(e[0],ae(e[1]+lt(t))),1)),at(e[0])),(()=>ct(ae(lt(t)),1))))]),Ge((()=>Pe(["onClick",e=>{var t;(t=e).preventDefault(),ft(ae(t.currentTarget.attributes.href.value),1,1)}]))))}))))))))))));return(0,Ye.createElement)("li",{children:Ke.Children.toArray(Array.from(r))})},u=pe([(0,Ye.createElement)("label",S(wt("drawer-overlay",ae(["htmlFor","main-menu"])))),(0,Ye.createElement)("aside",S(pe([["className","flex flex-col border-r w-80 bg-base-100 text-base-content"],(t=[(n=pe([(0,Ye.createElement)("span",{className:"text-primary",children:"Feliz.ChartJS"}),(0,Ye.createElement)("a",S(pe([["href","https://www.nuget.org/packages/Feliz.ChartJS"],(r=[(0,Ye.createElement)("img",{src:"https://img.shields.io/nuget/v/Feliz.ChartJS.svg?style=flat-square"})],["children",Ke.Children.toArray(Array.from(r))])])))]),(0,Ye.createElement)("div",{className:"inline-block text-3xl font-title px-5 py-5 font-bold",children:Ke.Children.toArray(Array.from(n))})),(0,Ye.createElement)("ul",S(wt("menu",pe([["className","menu-compact"],["className","flex flex-col p-4 pt-0"],(o=[(i=ae((0,Ye.createElement)("span",{children:["Docs"]})),(0,Ye.createElement)("li",{className:"menu-title",children:Ke.Children.toArray(Array.from(i))})),s("Install",new mt(0)),s("Use",new mt(1))],["children",Ke.Children.toArray(Array.from(o))])]))))],["children",Ke.Children.toArray(Array.from(t))])])))]);return(0,Ye.createElement)("div",{className:"drawer-side",children:Ke.Children.toArray(Array.from(u))})}function Ot(e,t,n,r,o,i){let s,u;return(0,Ye.createElement)("div",S(pe([["className","bg-base-100 text-base-content h-screen"],["data-theme",e.Theme],(s=[(0,Ye.createElement)("div",S(wt("drawer",pe([["className","drawer-mobile"],(u=[(0,Ye.createElement)("input",S(wt("drawer-toggle",pe([["type","checkbox"],["id","main-menu"]])))),Nt(0,0,n,0,i),It(o)],["children",Ke.Children.toArray(Array.from(u))])]))))],["children",Ke.Children.toArray(Array.from(s))])])))}function kt(e){let t;const n=e.dispatch,r=e.state;let o;switch(r.Page.tag){case 0:o=["Installation","/docs/install",(0,Ye.createElement)(Ct,null)];break;case 1:o=["How to use","/docs/use",(0,Ye.createElement)(St,null)];break;default:throw new Error("Match failure: Docs.Router.Page")}return ht(S(pe([["hashMode",1],["onUrlChanged",e=>{n(new xt(0,yt(e)))}],(t=ae(Ot(r,0,o[0],o[1],r.Page,o[2])),["application",Ye.createElement(Ye.Fragment,{},...t)])])))}var Tt,Mt;!function(e){Be(void 0,e)}(("safer-app",Mt=(e,t)=>(0,Ye.createElement)(kt,{state:e,dispatch:t}),Tt=new Ve((function(){const e=yt(dt(window.location.hash,1));return[new At(e,"light"),Et(e)]}),(function(e,t){return 1===e.tag?[new At(t.Page,e.fields[0]),be()]:[new At(e.fields[0],t.Theme),be()]}),(e=>be()),Mt,A(2,(e=>{const t=O(1,Mt,[e]);return e=>{t(e)}})),(e=>{var t,n;t=e[0],n=e[1],console.error(X(t),n)}),A(2,(e=>e))),function(e,t,n){return function(e,t){return new Ve(t.init,t.update,t.subscribe,t.view,e,t.onError,t.syncDispatch)}(((r,o)=>{We.render(e((e=>t=>e===t),function(e){return I(2,e.view)}(n),r,o),document.getElementById(t))}),n)}(((e,t,n,r)=>function(e,t,n,r){const o=new Xe(n,(()=>t(n,r)),e);return Ye.createElement(Ze,o)}(A(2,e),A(2,t),n,r)),"safer-app",Tt)))}},e=>{var t=t=>e(e.s=t);e.O(0,[216],(()=>(t(170),t(758)))),e.O()}]);
//# sourceMappingURL=app.4d10c57b732e4d402227.js.map