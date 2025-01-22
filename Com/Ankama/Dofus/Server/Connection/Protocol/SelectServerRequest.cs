using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E1E RID: 3614
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectServerRequest : IMessage<SelectServerRequest>, IMessage, IEquatable<SelectServerRequest>, IDeepCloneable<SelectServerRequest>, IBufferMessage
	{
		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x0029F7E8 File Offset: 0x0029D9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectServerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x0029F7F8 File Offset: 0x0029D9F8
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

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600ADD9 RID: 44505 RVA: 0x0029F808 File Offset: 0x0029DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x0029F818 File Offset: 0x0029DA18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerRequest()
		{
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x0029F828 File Offset: 0x0029DA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerRequest(SelectServerRequest other)
		{
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x0029F838 File Offset: 0x0029DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectServerRequest Clone()
		{
			return null;
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x0029F848 File Offset: 0x0029DA48
		// (set) Token: 0x0600ADDE RID: 44510 RVA: 0x0029F858 File Offset: 0x0029DA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Server
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x0029F868 File Offset: 0x0029DA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ADE0 RID: 44512 RVA: 0x0029F878 File Offset: 0x0029DA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SelectServerRequest other)
		{
			return true;
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x0029F888 File Offset: 0x0029DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x0029F898 File Offset: 0x0029DA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x0029F8A8 File Offset: 0x0029DAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x0029F8B8 File Offset: 0x0029DAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x0029F8C8 File Offset: 0x0029DAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x0029F8D8 File Offset: 0x0029DAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SelectServerRequest other)
		{
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x0029F8E8 File Offset: 0x0029DAE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x0029F8F8 File Offset: 0x0029DAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x0029F908 File Offset: 0x0029DB08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SelectServerRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SelectServerRequest._parser = new MessageParser<SelectServerRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x0029F9D4 File Offset: 0x0029DBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C6D73BJUS9toZYJNZ32u()
		{
			return true;
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x0029F9DC File Offset: 0x0029DBDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SelectServerRequest cuANyRJUMsyfjKMYoDZZ()
		{
			return null;
		}

		// Token: 0x04003FF5 RID: 16373
		private static readonly MessageParser<SelectServerRequest> _parser;

		// Token: 0x04003FF6 RID: 16374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FF7 RID: 16375
		public const int ServerFieldNumber = 1;

		// Token: 0x04003FF8 RID: 16376
		private int server_;

		// Token: 0x04003FF9 RID: 16377
		internal static SelectServerRequest n8l6nvJUPgsIpL3gAbuX;
	}
}
