using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E05 RID: 3589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateServerEvent : IMessage<UpdateServerEvent>, IMessage, IEquatable<UpdateServerEvent>, IDeepCloneable<UpdateServerEvent>, IBufferMessage
	{
		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600ACBB RID: 44219 RVA: 0x0029ECB4 File Offset: 0x0029CEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateServerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x0029ECC4 File Offset: 0x0029CEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600ACBD RID: 44221 RVA: 0x0029ECD4 File Offset: 0x0029CED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x0029ECE4 File Offset: 0x0029CEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateServerEvent()
		{
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x0029ECF4 File Offset: 0x0029CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateServerEvent(UpdateServerEvent other)
		{
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x0029ED04 File Offset: 0x0029CF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateServerEvent Clone()
		{
			return null;
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600ACC1 RID: 44225 RVA: 0x0029ED14 File Offset: 0x0029CF14
		// (set) Token: 0x0600ACC2 RID: 44226 RVA: 0x0029ED24 File Offset: 0x0029CF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerInformation ServerInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x0029ED34 File Offset: 0x0029CF34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x0029ED44 File Offset: 0x0029CF44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UpdateServerEvent other)
		{
			return true;
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x0029ED54 File Offset: 0x0029CF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x0029ED64 File Offset: 0x0029CF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x0029ED74 File Offset: 0x0029CF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x0029ED84 File Offset: 0x0029CF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x0029ED94 File Offset: 0x0029CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x0029EDA4 File Offset: 0x0029CFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UpdateServerEvent other)
		{
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x0029EDB4 File Offset: 0x0029CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x0029EDC4 File Offset: 0x0029CFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x0029EDD4 File Offset: 0x0029CFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UpdateServerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UpdateServerEvent._parser = new MessageParser<UpdateServerEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x0029EEA0 File Offset: 0x0029D0A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YQ2Y3FJUVI71gH8rd0aa()
		{
			return true;
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x0029EEA8 File Offset: 0x0029D0A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UpdateServerEvent SyRcOYJU0NyeflQy3aBD()
		{
			return null;
		}

		// Token: 0x04003F77 RID: 16247
		private static readonly MessageParser<UpdateServerEvent> _parser;

		// Token: 0x04003F78 RID: 16248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F79 RID: 16249
		public const int ServerInformationFieldNumber = 1;

		// Token: 0x04003F7A RID: 16250
		private ServerInformation serverInformation_;

		// Token: 0x04003F7B RID: 16251
		internal static UpdateServerEvent DGTfooJUrrR3ahcTirqN;
	}
}
