using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A9A RID: 2714
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterTaxCollectorLightInformation : IMessage<FighterTaxCollectorLightInformation>, IMessage, IEquatable<FighterTaxCollectorLightInformation>, IDeepCloneable<FighterTaxCollectorLightInformation>, IBufferMessage
	{
		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x002615DC File Offset: 0x0025F7DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FighterTaxCollectorLightInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x0600819A RID: 33178 RVA: 0x002615EC File Offset: 0x0025F7EC
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x002615FC File Offset: 0x0025F7FC
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

		// Token: 0x0600819C RID: 33180 RVA: 0x0026160C File Offset: 0x0025F80C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterTaxCollectorLightInformation()
		{
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x0026161C File Offset: 0x0025F81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterTaxCollectorLightInformation(FighterTaxCollectorLightInformation other)
		{
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x0026162C File Offset: 0x0025F82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterTaxCollectorLightInformation Clone()
		{
			return null;
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x0600819F RID: 33183 RVA: 0x0026163C File Offset: 0x0025F83C
		// (set) Token: 0x060081A0 RID: 33184 RVA: 0x0026164C File Offset: 0x0025F84C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstNameId
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

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x0026165C File Offset: 0x0025F85C
		// (set) Token: 0x060081A2 RID: 33186 RVA: 0x0026166C File Offset: 0x0025F86C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LastNameId
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

		// Token: 0x060081A3 RID: 33187 RVA: 0x0026167C File Offset: 0x0025F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x0026168C File Offset: 0x0025F88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterTaxCollectorLightInformation other)
		{
			return true;
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x0026169C File Offset: 0x0025F89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x002616AC File Offset: 0x0025F8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x002616BC File Offset: 0x0025F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x002616CC File Offset: 0x0025F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x002616DC File Offset: 0x0025F8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x002616EC File Offset: 0x0025F8EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterTaxCollectorLightInformation other)
		{
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x002616FC File Offset: 0x0025F8FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x0026170C File Offset: 0x0025F90C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x0026171C File Offset: 0x0025F91C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterTaxCollectorLightInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					FighterTaxCollectorLightInformation._parser = new MessageParser<FighterTaxCollectorLightInformation>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x00261800 File Offset: 0x0025FA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AopfpEJgwbw1ocXcVr2N()
		{
			return true;
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x00261808 File Offset: 0x0025FA08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterTaxCollectorLightInformation LyIJiHJgQ3dinVhoDHff()
		{
			return null;
		}

		// Token: 0x04002F26 RID: 12070
		private static readonly MessageParser<FighterTaxCollectorLightInformation> _parser;

		// Token: 0x04002F27 RID: 12071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F28 RID: 12072
		public const int FirstNameIdFieldNumber = 1;

		// Token: 0x04002F29 RID: 12073
		private int firstNameId_;

		// Token: 0x04002F2A RID: 12074
		public const int LastNameIdFieldNumber = 2;

		// Token: 0x04002F2B RID: 12075
		private int lastNameId_;

		// Token: 0x04002F2C RID: 12076
		private static FighterTaxCollectorLightInformation QIbnxXJgtMOiFI7uNfLW;
	}
}
