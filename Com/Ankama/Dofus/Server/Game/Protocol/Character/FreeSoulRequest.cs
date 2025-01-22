using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008E7 RID: 2279
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FreeSoulRequest : IMessage<FreeSoulRequest>, IMessage, IEquatable<FreeSoulRequest>, IDeepCloneable<FreeSoulRequest>, IBufferMessage
	{
		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x00237CD4 File Offset: 0x00235ED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FreeSoulRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06006EBD RID: 28349 RVA: 0x00237CE4 File Offset: 0x00235EE4
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

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06006EBE RID: 28350 RVA: 0x00237CF4 File Offset: 0x00235EF4
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

		// Token: 0x06006EBF RID: 28351 RVA: 0x00237D04 File Offset: 0x00235F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FreeSoulRequest()
		{
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00237D14 File Offset: 0x00235F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FreeSoulRequest(FreeSoulRequest other)
		{
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00237D24 File Offset: 0x00235F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FreeSoulRequest Clone()
		{
			return null;
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00237D34 File Offset: 0x00235F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x00237D44 File Offset: 0x00235F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FreeSoulRequest other)
		{
			return true;
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x00237D54 File Offset: 0x00235F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00237D64 File Offset: 0x00235F64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x00237D74 File Offset: 0x00235F74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x00237D84 File Offset: 0x00235F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x00237D94 File Offset: 0x00235F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x00237DA4 File Offset: 0x00235FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FreeSoulRequest other)
		{
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x00237DB4 File Offset: 0x00235FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x00237DC4 File Offset: 0x00235FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00237DD4 File Offset: 0x00235FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FreeSoulRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FreeSoulRequest._parser = new MessageParser<FreeSoulRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00237EB8 File Offset: 0x002360B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TWLDMKJBdsnfeKJnknLj()
		{
			return true;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00237EC0 File Offset: 0x002360C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FreeSoulRequest XaaEGrJB9EH1f0GOYsNM()
		{
			return null;
		}

		// Token: 0x040026CA RID: 9930
		private static readonly MessageParser<FreeSoulRequest> _parser;

		// Token: 0x040026CB RID: 9931
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CC RID: 9932
		internal static FreeSoulRequest wHLCIEJBsfaUagBXidXs;
	}
}
