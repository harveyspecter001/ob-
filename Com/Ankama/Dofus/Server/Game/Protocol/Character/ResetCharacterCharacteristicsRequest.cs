using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008E5 RID: 2277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ResetCharacterCharacteristicsRequest : IMessage<ResetCharacterCharacteristicsRequest>, IMessage, IEquatable<ResetCharacterCharacteristicsRequest>, IDeepCloneable<ResetCharacterCharacteristicsRequest>, IBufferMessage
	{
		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x00237AF8 File Offset: 0x00235CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ResetCharacterCharacteristicsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06006EA5 RID: 28325 RVA: 0x00237B08 File Offset: 0x00235D08
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

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x00237B18 File Offset: 0x00235D18
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

		// Token: 0x06006EA7 RID: 28327 RVA: 0x00237B28 File Offset: 0x00235D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResetCharacterCharacteristicsRequest()
		{
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x00237B38 File Offset: 0x00235D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResetCharacterCharacteristicsRequest(ResetCharacterCharacteristicsRequest other)
		{
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00237B48 File Offset: 0x00235D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResetCharacterCharacteristicsRequest Clone()
		{
			return null;
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x00237B58 File Offset: 0x00235D58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x00237B68 File Offset: 0x00235D68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ResetCharacterCharacteristicsRequest other)
		{
			return true;
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00237B78 File Offset: 0x00235D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x00237B88 File Offset: 0x00235D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00237B98 File Offset: 0x00235D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00237BA8 File Offset: 0x00235DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00237BB8 File Offset: 0x00235DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00237BC8 File Offset: 0x00235DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ResetCharacterCharacteristicsRequest other)
		{
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00237BD8 File Offset: 0x00235DD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00237BE8 File Offset: 0x00235DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00237BF8 File Offset: 0x00235DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ResetCharacterCharacteristicsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 0;
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
				ResetCharacterCharacteristicsRequest._parser = new MessageParser<ResetCharacterCharacteristicsRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00237CC4 File Offset: 0x00235EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wUFOCxJBG7d8dDST88Wn()
		{
			return true;
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x00237CCC File Offset: 0x00235ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ResetCharacterCharacteristicsRequest pGTtbLJBgAIWZOykeHFJ()
		{
			return null;
		}

		// Token: 0x040026C5 RID: 9925
		private static readonly MessageParser<ResetCharacterCharacteristicsRequest> _parser;

		// Token: 0x040026C6 RID: 9926
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C7 RID: 9927
		private static ResetCharacterCharacteristicsRequest XpnDaEJBJMtoPYgNIryL;
	}
}
