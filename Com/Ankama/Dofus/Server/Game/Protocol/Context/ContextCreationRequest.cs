using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000803 RID: 2051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextCreationRequest : IMessage<ContextCreationRequest>, IMessage, IEquatable<ContextCreationRequest>, IDeepCloneable<ContextCreationRequest>, IBufferMessage
	{
		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x00225DF8 File Offset: 0x00223FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextCreationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060063D9 RID: 25561 RVA: 0x00225E08 File Offset: 0x00224008
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060063DA RID: 25562 RVA: 0x00225E18 File Offset: 0x00224018
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

		// Token: 0x060063DB RID: 25563 RVA: 0x00225E28 File Offset: 0x00224028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationRequest()
		{
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00225E38 File Offset: 0x00224038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationRequest(ContextCreationRequest other)
		{
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00225E48 File Offset: 0x00224048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextCreationRequest Clone()
		{
			return null;
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00225E58 File Offset: 0x00224058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00225E68 File Offset: 0x00224068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextCreationRequest other)
		{
			return true;
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00225E78 File Offset: 0x00224078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x00225E88 File Offset: 0x00224088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x00225E98 File Offset: 0x00224098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00225EA8 File Offset: 0x002240A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x00225EB8 File Offset: 0x002240B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00225EC8 File Offset: 0x002240C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextCreationRequest other)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00225ED8 File Offset: 0x002240D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00225EE8 File Offset: 0x002240E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00225EF8 File Offset: 0x002240F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextCreationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				ContextCreationRequest._parser = new MessageParser<ContextCreationRequest>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00225FDC File Offset: 0x002241DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nF8YmUOzc0ko3nh5mytV()
		{
			return true;
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00225FE4 File Offset: 0x002241E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextCreationRequest JxloUSOzUkvvOhXK5JeK()
		{
			return null;
		}

		// Token: 0x04002323 RID: 8995
		private static readonly MessageParser<ContextCreationRequest> _parser;

		// Token: 0x04002324 RID: 8996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002325 RID: 8997
		private static ContextCreationRequest sybFaEOzlPauVsi4VuFW;
	}
}
