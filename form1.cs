using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Xml;

namespace LocalWebHost
{
    public partial class Form1 : Form
    {
        WebServer ws;
        public Form1()
        {
            InitializeComponent();
        }
        private string StringUrl = "http://localhost:8080/current/";
        private void InitWs()
        {
            ws = new WebServer(SendRes, StringUrl);
            ws.Run();
            Console.WriteLine("Creating Webserver on {0}", StringUrl);
            this.textBox1.Text = StringUrl;
        }
        private string SendRes(HttpListenerRequest req)
        {

            return string.Format("<?xml version='1.0' encoding='UTF-8'?><MTConnectStreams xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'><Header creationTime='2016-11-16T11:53:02Z' nextSequence='119035' instanceId='636147967237890601' sender='10.24.201.98' bufferSize='100' firstSequence='0' lastSequence='119034' version='1.3' assetBufferSize='0' assetCount='0' /><Streams><DeviceStream name='" + this.textBox2.Text + "' uuid='xxx'><ComponentStream component='Linear' name='X' componentId='x'><Samples><Position dataItemId='xp' timestamp='2016-11-16T05:34:43.0000' name='axpos0' subType='ACTUAL' sequence='119032'>" + this.textBox3.Text + "</Position><AxisFeedrate dataItemId='xf' timestamp='2016-11-16T05:34:43.0000' name='axfeed0' sequence='119033'>" + this.textBox4.Text + "</AxisFeedrate></Samples></ComponentStream><ComponentStream component='Linear' name='Y' componentId='y'><Samples><Position dataItemId='yp' timestamp='2016-11-16T03:15:17.0000' name='axpos1' subType='ACTUAL' sequence='118952'>" + this.textBox5.Text + "</Position><AxisFeedrate dataItemId='yf' timestamp='2016-11-16T03:15:17.0000' name='axfeed1' sequence='118953'>" + this.textBox6.Text + "</AxisFeedrate></Samples></ComponentStream><ComponentStream component='Linear' name='Z' componentId='z'><Samples><Position dataItemId='zp' timestamp='2016-11-16T03:16:01.0000' name='axpos2' subType='ACTUAL' sequence='118990'>" + this.textBox7.Text + "</Position><AxisFeedrate dataItemId='zf' timestamp='2016-11-16T03:16:01.0000' name='axfeed2' sequence='118991'>" + this.textBox8.Text + "</AxisFeedrate></Samples></ComponentStream><ComponentStream component='Rotary' name='C0' componentId='c0'><Samples><Load dataItemId='cl0' timestamp='2016-11-16T03:15:21.0000' name='sload0' sequence='118967'>" + this.textBox9.Text + "</Load><SpindleSpeed dataItemId='cs0' timestamp='2016-11-16T03:15:21.0000' name='sspeed0' subType='ACTUAL' sequence='118968'>" + this.textBox10.Text + "</SpindleSpeed><SpindleSpeed dataItemId='cso0' timestamp='2016-11-15T11:10:44.0000' name='sovr0' subType='OVERRIDE' sequence='17608'>" + this.textBox11.Text + "</SpindleSpeed><Amperage dataItemId='csa0' timestamp='2016-11-15T08:50:08.0000' name='spa0' sequence='9'>" + this.textBox12.Text + "</Amperage><Voltage dataItemId='csv0' timestamp='2016-11-15T08:50:08.0000' name='spv0' sequence='10'>" + this.textBox13.Text + "</Voltage></Samples><Events><ActuatorState dataItemId='sss0' timestamp='2016-11-15T08:50:08.0000' name='spindle0' sequence='11'>" + this.textBox14.Text + "</ActuatorState><RotaryMode dataItemId='cr0' timestamp='2016-11-15T08:50:08.0000' name='rotary_mode' sequence='12'>" + this.textBox15.Text + "</RotaryMode><Direction dataItemId='cdir0' timestamp='2016-11-16T03:15:21.0000' name='direction' subType='ROTARY' sequence='118969'>" + this.textBox16.Text + "</Direction></Events></ComponentStream><ComponentStream component='Rotary' name='C1' componentId='c1'><Samples><Load dataItemId='cl1' timestamp='2016-11-16T03:15:21.0000' name='sload1' sequence='118970'>" + this.textBox17.Text + "</Load><SpindleSpeed dataItemId='cs1' timestamp='2016-11-16T03:15:21.0000' name='sspeed1' subType='ACTUAL' sequence='118971'>" + this.textBox18.Text + "</SpindleSpeed><SpindleSpeed dataItemId='cso1' timestamp='2016-11-15T11:10:44.0000' name='sovr1' subType='OVERRIDE' sequence='17609'>" + this.textBox19.Text + "</SpindleSpeed><Amperage dataItemId='csa1' timestamp='2016-11-15T08:50:08.0000' name='spa1' sequence='17'>" + this.textBox20.Text + "</Amperage><Voltage dataItemId='csv1' timestamp='2016-11-15T08:50:08.0000' name='spv1' sequence='18'>" + this.textBox21.Text + "</Voltage></Samples><Events><ActuatorState dataItemId='sss1' timestamp='2016-11-15T08:50:08.0000' name='spindle1' sequence='19'>" + this.textBox22.Text + "</ActuatorState><RotaryMode dataItemId='cr1' timestamp='2016-11-15T08:50:08.0000' name='rotary_mode' sequence='20'>" + this.textBox23.Text + "</RotaryMode><Direction dataItemId='cdir1' timestamp='2016-11-16T03:15:21.0000' name='direction' subType='ROTARY' sequence='118972'>" + this.textBox24.Text + "</Direction></Events></ComponentStream><ComponentStream component='Rotary' name='C2' componentId='c2'><Samples><Load dataItemId='cl2' timestamp='2016-11-16T03:15:21.0000' name='sload2' sequence='118973'>" + this.textBox25.Text + "</Load><SpindleSpeed dataItemId='cs2' timestamp='2016-11-16T03:15:21.0000' name='sspeed2' subType='ACTUAL' sequence='118974'>" + this.textBox26.Text + "</SpindleSpeed><SpindleSpeed dataItemId='cso2' timestamp='2016-11-15T11:10:44.0000' name='sovr2' subType='OVERRIDE' sequence='17610'>" + this.textBox27.Text + "</SpindleSpeed><Amperage dataItemId='csa2' timestamp='2016-11-15T08:50:08.0000' name='spa2' sequence='25'>" + this.textBox28.Text + "</Amperage><Voltage dataItemId='csv2' timestamp='2016-11-15T08:50:08.0000' name='spv2' sequence='26'>" + this.textBox29.Text + "</Voltage></Samples><Events><ActuatorState dataItemId='sss2' timestamp='2016-11-15T08:50:08.0000' name='spindle2' sequence='27'>" + this.textBox30.Text + "</ActuatorState><RotaryMode dataItemId='cr2' timestamp='2016-11-15T08:50:08.0000' name='rotary_mode' sequence='28'>" + this.textBox31.Text + "</RotaryMode><Direction dataItemId='cdir2' timestamp='2016-11-16T03:15:21.0000' name='direction' subType='ROTARY' sequence='118975'>" + this.textBox32.Text + "</Direction></Events></ComponentStream><ComponentStream component='Rotary' name='C3' componentId='c3'><Samples><Load dataItemId='cl3' timestamp='2016-11-16T03:15:21.0000' name='sload3' sequence='118976'>" + this.textBox33.Text + "</Load><SpindleSpeed dataItemId='cs3' timestamp='2016-11-16T03:15:21.0000' name='sspeed3' subType='ACTUAL' sequence='118977'>" + this.textBox34.Text + "</SpindleSpeed><SpindleSpeed dataItemId='cso3' timestamp='2016-11-15T11:10:44.0000' name='sovr3' subType='OVERRIDE' sequence='17611'>" + this.textBox35.Text + "</SpindleSpeed><Amperage dataItemId='csa3' timestamp='2016-11-15T08:50:08.0000' name='spa3' sequence='33'>" + this.textBox36.Text + "</Amperage><Voltage dataItemId='csv3' timestamp='2016-11-15T08:50:08.0000' name='spv3' sequence='34'>" + this.textBox37.Text + "</Voltage></Samples><Events><ActuatorState dataItemId='sss3' timestamp='2016-11-15T08:50:08.0000' name='spindle3' sequence='35'>" + this.textBox38.Text + "</ActuatorState><RotaryMode dataItemId='cr3' timestamp='2016-11-15T08:50:08.0000' name='rotary_mode' sequence='36'>" + this.textBox39.Text + "</RotaryMode><Direction dataItemId='cdir3' timestamp='2016-11-16T03:15:21.0000' name='direction' subType='ROTARY' sequence='118978'>" + this.textBox40.Text + "</Direction></Events></ComponentStream><ComponentStream component='Rotary' name='C4' componentId='c4'><Samples><Load dataItemId='cl4' timestamp='2016-11-16T03:15:21.0000' name='sload4' sequence='118979'>" + this.textBox41.Text + "</Load><SpindleSpeed dataItemId='cs4' timestamp='2016-11-16T03:15:21.0000' name='sspeed4' subType='ACTUAL' sequence='118980'>" + this.textBox42.Text + "</SpindleSpeed><SpindleSpeed dataItemId='cso4' timestamp='2016-11-15T11:10:44.0000' name='sovr4' subType='OVERRIDE' sequence='17612'>" + this.textBox43.Text + "</SpindleSpeed><Amperage dataItemId='csa4' timestamp='2016-11-15T08:50:08.0000' name='spa4' sequence='41'>" + this.textBox44.Text + "</Amperage><Voltage dataItemId='csv4' timestamp='2016-11-15T08:50:08.0000' name='spv4' sequence='42'>" + this.textBox45.Text + "</Voltage></Samples><Events><ActuatorState dataItemId='sss4' timestamp='2016-11-15T08:50:08.0000' name='spindle4' sequence='43'>" + this.textBox46.Text + "</ActuatorState><RotaryMode dataItemId='cr4' timestamp='2016-11-15T08:50:08.0000' name='rotary_mode' sequence='44'>" + this.textBox47.Text + "</RotaryMode><Direction dataItemId='cdir4' timestamp='2016-11-16T03:15:21.0000' name='direction' subType='ROTARY' sequence='118981'>" + this.textBox48.Text + "</Direction></Events></ComponentStream><ComponentStream component='Controller' name='controller' componentId='cont'><Events><EmergencyStop dataItemId='eSTOP' timestamp='2016-11-15T08:50:08.0000' name='system_cond' sequence='47'>" + this.textBox49.Text + "</EmergencyStop></Events><Conditions><NORMAL dataItemId='system' timestamp='2016-11-16T02:13:49.0000' name='system_cond' sequence='112532' type='SYSTEM'>" + this.textBox50.Text + "</NORMAL></Conditions></ComponentStream><ComponentStream component='Path' name='path' componentId='path1'><Samples><PathFeedrate dataItemId='fovr' timestamp='2016-11-16T02:41:15.0000' name='fovr' subType='OVERRIDE' sequence='112849'>" + this.textBox51.Text + "</PathFeedrate></Samples><Events><ToolId dataItemId='cnt1' timestamp='2016-11-15T08:50:08.0000' name='tool_id' sequence='49'>" + this.textBox52.Text + "</ToolId><Program dataItemId='program' timestamp='2016-11-16T02:13:49.0000' name='program' sequence='112533'>" + this.textBox53.Text + "</Program><Line dataItemId='line' timestamp='2016-11-16T05:13:06.0000' name='line' sequence='119008'>" + this.textBox54.Text + "</Line><Block dataItemId='block' timestamp='2016-11-16T05:13:06.0000' name='block' sequence='119009'>" + this.textBox55.Text + "</Block><Execution dataItemId='exec' timestamp='2016-11-16T05:13:21.0000' name='execution' sequence='119017'>" + this.textBox56.Text + "</Execution><ControllerMode dataItemId='mode' timestamp='2016-11-16T05:13:21.0000' name='mode' sequence='119018'>" + this.textBox57.Text + "</ControllerMode></Events></ComponentStream></DeviceStream></Streams></MTConnectStreams>");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitWs();
            this.label57.Text = "Server Status: Running";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws.Stop();
            this.label57.Text = "Server Status: Stopped";
        }


    }


    public class WebServer
    {
        private readonly HttpListener _listener = new HttpListener();
        private readonly Func<HttpListenerRequest, string> _responderMethod;

        public WebServer(string[] prefixes, Func<HttpListenerRequest, string> method)
        {
            if (!HttpListener.IsSupported)
                throw new NotSupportedException(
                    "Needs Windows XP SP2, Server 2003 or later.");

            // URI prefixes are required, for example 
            // "http://localhost:8080/current".
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // A responder method is required
            if (method == null)
                throw new ArgumentException("method");

            foreach (string s in prefixes)
                _listener.Prefixes.Add(s);

            _responderMethod = method;
            _listener.Start();
        }

        public WebServer(Func<HttpListenerRequest, string> method, params string[] prefixes)
            : this(prefixes, method) { }

        public void Run()
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine("Webserver running...");
                try
                {
                    while (_listener.IsListening)
                    {
                        ThreadPool.QueueUserWorkItem((c) =>
                        {
                            var ctx = c as HttpListenerContext;
                            try
                            {
                                string rstr = _responderMethod(ctx.Request);
                                byte[] buf = Encoding.UTF8.GetBytes(rstr);
                                ctx.Response.ContentLength64 = buf.Length;
                                ctx.Response.OutputStream.Write(buf, 0, buf.Length);
                            }
                            catch { } // suppress any exceptions
                            finally
                            {
                                // always close the stream
                                ctx.Response.OutputStream.Close();
                            }
                        }, _listener.GetContext());
                    }
                }
                catch { } // suppress any exceptions
            });
        }

        public void Stop()
        {
            _listener.Stop();
            _listener.Close();
        }
    }

}
